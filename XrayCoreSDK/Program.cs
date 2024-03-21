namespace XrayCoreSDK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Log("usage: xraycoresdk.exe path/to/Xray-core");
                return;
            }

            var cwd = Environment.CurrentDirectory;
            var src = new DirectoryInfo(Path.Combine(cwd, args[0])).FullName;
            Log($"source dir: {src}");
            if (!Directory.Exists(src))
            {
                Log("Xray-core source code folder not found");
                return;
            }

            var compiler = CreateComplier(src);
            if (compiler == null)
            {
                return;
            }

            var sdk = Path.Combine(cwd, "sdk");
            if (Directory.Exists(sdk))
            {
                Log($"delete dir: {sdk}");
                Directory.Delete(sdk, true);
            }
            Directory.CreateDirectory(sdk);

            var success = 0;
            var failed = 0;

            var protos = Directory.GetFiles(src, "*.proto", SearchOption.AllDirectories);
            foreach (var proto in protos)
            {
                var dest = Path.GetDirectoryName(
                    Path.Combine(sdk, proto.Substring(src.Length + 1))
                );
                Log($"compiling: {proto}");
                Log($"to: {dest}");
                if (!string.IsNullOrEmpty(dest))
                {
                    var ok = compiler.Compile(proto, dest);
                    if (ok)
                    {
                        success++;
                        Log("result: success");
                    }
                    else
                    {
                        failed++;
                        Log("result: failed");
                    }
                }
                else
                {
                    Log($"error: dest is empty");
                }
            }
            var code = Path.Combine("sdk", "Utils.cs");
            File.WriteAllText(code, Codes.Utils);
            Log($"total: {success + failed} success: {success} failed: {failed}");
            Log("done");
        }

        private static Compiler? CreateComplier(string include)
        {
            var profile = Environment.GetEnvironmentVariable("UserProfile");
            if (profile == null)
            {
                Log("get user profile failed");
                return null;
            }
            var protoc = GenPath(profile, "protoc.exe");
            if (!File.Exists(protoc))
            {
                Log("protoc.exe not found");
                return null;
            }
            var plugin = GenPath(profile, "grpc_csharp_plugin.exe");
            if (!File.Exists(plugin))
            {
                Log("protoc.exe not found");
                return null;
            }

            return new Compiler(protoc, plugin, include);
        }

        static void Log(params string[] args)
        {
            Console.WriteLine(string.Join(" ", args));
        }

        static string GenPath(string root, string append)
        {
            return Path.Combine(
                root,
                ".nuget",
                "packages",
                "grpc.tools",
                "2.62.0",
                "tools",
                "windows_x64",
                append
            );
        }
    }

    internal class Compiler
    {
        private readonly string protoc;
        private readonly string plugin;
        private readonly string include;

        public Compiler(string protoc, string plugin, string include)
        {
            this.protoc = protoc;
            this.plugin = plugin;
            this.include = include;
        }

        public bool Compile(string src, string target)
        {
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            var process = new System.Diagnostics.Process();
            var startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = protoc;
            startInfo.Arguments =
                $"--csharp_out {target} --grpc_out {target} --plugin=protoc-gen-grpc={plugin} -I {include}";
            startInfo.Arguments += $" {src}";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            return process.ExitCode == 0;
        }
    }
}
