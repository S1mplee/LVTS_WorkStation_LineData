using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUI.models
{
    public class Service
    {

        public void editingFile(string Rockwavepath1, string Codejockpath, int version,string path)
        {
            List<string> text = new List<string>();
            string Rockwavepath12 = "", Rockwavepath22 = "", Codejockpath2 = "", codejockpath3 = "";
            switch (version)
            {
                case 7530: Rockwavepath12 = Rockwavepath1 + "\\Bin"; Rockwavepath22 = Rockwavepath1 + "\\lib\\vc12\\x64"; Codejockpath2 = Codejockpath + "\\Bin\\vc120x64"; codejockpath3 = Codejockpath + "\\Lib\\vc120x64"; break;
                case 7200: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7300: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7400: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7500: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc120"; codejockpath3 = Codejockpath + "\\Lib\\vc120"; break;
                default: break;
            }
            // ==
            text.Add("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            text.Add("<Project DefaultTargets=\"Build\" ToolsVersion=\"4.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ExecutablePath>$(ExecutablePath);" + path + "\\" + Codejockpath2 + ";" + path + "\\" + Rockwavepath22 + "</ExecutablePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <IncludePath>$(IncludePath);" + path + "\\" + Codejockpath + "\\Source;" + path + "\\" + Rockwavepath1 + "\\Include;" + path + "\\" + "\\" + Rockwavepath1 + "\\Regex\\include;" + path + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ReferencePath>$(ReferencePath);"+path+"\\"+"Xceed\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <LibraryPath>$(LibraryPath);" + path + "\\" + codejockpath3 + ";" + path + "\\" + Rockwavepath22 + "</LibraryPath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <SourcePath>$(SourcePath);" + path + "\\" + Codejockpath + "\\Source;" + path + "\\" + Rockwavepath1 + "\\Src;" + path + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ExcludePath>$(ExcludePath)</ExcludePath>");
            text.Add("  </PropertyGroup>");
                // !=
         
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <ExecutablePath>$(ExecutablePath);" + path + "\\" + Codejockpath2 + ";" + path + "\\" + Rockwavepath22 + "</ExecutablePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <IncludePath>$(IncludePath);" + path + "\\" + Codejockpath + "\\Source;" + path + "\\" + Rockwavepath1 + "\\Include;" + path + "\\" + Rockwavepath1 + "\\Regex\\include;" + path + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <ReferencePath>$(ReferencePath);"+path+"\\"+"Xceed\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <LibraryPath>$(LibraryPath);" + path + "\\" + codejockpath3 + ";" + path + "\\" + Rockwavepath22 + "</LibraryPath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <SourcePath>$(SourcePath);" + path + "\\" + Codejockpath + "\\Source;" + path + "\\" + Rockwavepath1 + "\\Src;" + path + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <ExcludePath>$(ExcludePath)</ExcludePath>");
            text.Add("  </PropertyGroup>");
            text.Add("  <ItemDefinitionGroup>");
            text.Add("    <ClCompile>");
            text.Add("      <MultiProcessorCompilation>true</MultiProcessorCompilation>");
            text.Add("    </ClCompile>");
            text.Add("  </ItemDefinitionGroup>");
            text.Add("</Project>");


          //  File.Create("Microsoft.Cpp.x64.user.props");
           // File.Create("Microsoft.Cpp.Win32.user.props");
            // C:\Users\MSI\AppData\Local\Microsoft\MSBuild\v4.0\Microsoft.Cpp.x64.user.props
            File.WriteAllLines("C:\\Users\\"+Environment.UserName+"\\AppData\\Local\\Microsoft\\MSBuild\\v4.0\\Microsoft.Cpp.x64.user.props", text);
            File.WriteAllLines("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Microsoft\\MSBuild\\v4.0\\Microsoft.Cpp.Win32.user.props", text);

        }

        public bool PerlVerif()
        {
            // Verification de l'existence de perl dans l'environement 
            String EnvironmentPath = System.Environment
                .GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine).ToLower();
            // Perl
            if (EnvironmentPath.Contains("perl"))
            {
                return true;
            }
            else
            {
                return false;

            }
            
        }

        public  void Update_MSBUILD(string RockwavePath, string CodjocksoftwarePath, int version,string path)
        {
            string Rockwavepath1 = "", Rockwavepath2 = "";
            switch (version)
            {
                case 7200: Rockwavepath1 = path + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = path + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = path + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7500: Rockwavepath1 = path + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = path + "\\" + CodjocksoftwarePath + "\\Bin\\vc120"; Rockwavepath2 = path + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7530: Rockwavepath1 = path + "\\" + RockwavePath + "\\Bin"; CodjocksoftwarePath = path + "\\" + CodjocksoftwarePath + "\\Bin\\vc120x64"; Rockwavepath2 = path + "\\" + RockwavePath + "\\lib\\vc12\\x64"; break;
                case 7300: Rockwavepath1 = path + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = path + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = path + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7400: Rockwavepath1 = path + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = path + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = path + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;


            }

            const string name = "PATH";
            string url = Rockwavepath1 + ";" + Rockwavepath2 + ";" + CodjocksoftwarePath;
            Console.WriteLine(url);
            string pathvar = System.Environment.GetEnvironmentVariable(name);
            var value = pathvar + @";" + url;
            var target = EnvironmentVariableTarget.Machine;
            System.Environment.SetEnvironmentVariable(name, value, target);

        }

        public bool AutoBuild(string param)
        {
            string projectFilePath = Path.Combine(@"C:\Users\MSI\source\repos\FirstApp\FirstApp.sln");

            ProjectCollection pc = new ProjectCollection();

            // THERE ARE A LOT OF PROPERTIES HERE, THESE MAP TO THE MSBUILD CLI PROPERTIES
            Dictionary<string, string> GlobalProperty = new Dictionary<string, string>();
            GlobalProperty.Add("Configuration", "Debug");
          //  GlobalProperty.Add("Platform", "Any CPU");
           // GlobalProperty.Add("OutputPath", @"C:\Output");

            BuildParameters bp = new BuildParameters(pc);
            MsBuildMemoryLogger customLogger = new MsBuildMemoryLogger();
            bp.Loggers = new List<ILogger>() { customLogger };
            BuildRequestData BuidlRequest = new BuildRequestData(projectFilePath, GlobalProperty, "12.0", new string[] { param }, null);
            // A SIMPLE WAY TO CHECK THE RESULT
            BuildResult buildResult = BuildManager.DefaultBuildManager.Build(bp, BuidlRequest);
            if (buildResult.OverallResult == BuildResultCode.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsValidPath(string path)
        {
            bool isValid = true;

            if (System.IO.Directory.Exists(path))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
