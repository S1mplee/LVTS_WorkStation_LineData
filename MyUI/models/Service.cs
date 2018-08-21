
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

        public void editingFile(string Rockwavepath1, string Codejockpath, int version,string pathRogue,string pathCodjock,string pathXceed)
        {
            List<string> text = new List<string>();
            string Rockwavepath12 = "", Rockwavepath22 = "", Codejockpath2 = "", codejockpath3 = "";
            switch (version)
            {
                case 7530: Rockwavepath12 = Rockwavepath1 + "\\Bin"; Rockwavepath22 = Rockwavepath1 + "\\Lib\\vc12\\x64"; Codejockpath2 = Codejockpath + "\\Bin\\vc120x64"; codejockpath3 = Codejockpath + "\\Lib\\vc120x64"; break;
                case 7200: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7300: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7400: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc100"; codejockpath3 = Codejockpath + "\\Lib\\vc100"; break;
                case 7500: Rockwavepath12 = Rockwavepath1 + "\\Lib"; Rockwavepath22 = Rockwavepath1 + "\\Regex\\lib\\VC6"; Codejockpath2 = Codejockpath + "\\Bin\\vc120"; codejockpath3 = Codejockpath + "\\Lib\\vc120"; break;
                default: break;
            }
            if (version == 7530) { 
            // ==
            text.Add("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            text.Add("<Project DefaultTargets=\"Build\" ToolsVersion=\"4.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ExecutablePath>$(ExecutablePath);" + pathCodjock + "\\" + Codejockpath2 + ";" + pathRogue + "\\" + Rockwavepath12 + "</ExecutablePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <IncludePath>$(IncludePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Include;" + pathRogue  + "\\" + Rockwavepath1 + "\\Regex\\include;" + pathRogue + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ReferencePath>$(ReferencePath);" + pathXceed  + "\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <LibraryPath>$(LibraryPath);" + pathCodjock + "\\" + codejockpath3 + ";" + pathRogue + "\\" + Rockwavepath22 + "</LibraryPath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <SourcePath>$(SourcePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Src;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
            text.Add("    <ExcludePath>$(ExcludePath)</ExcludePath>");
            text.Add("  </PropertyGroup>");
                // !=
         
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <ExecutablePath>$(ExecutablePath);" + pathCodjock + "\\" + Codejockpath2 + ";" + pathRogue + "\\" + Rockwavepath22 + "</ExecutablePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <IncludePath>$(IncludePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Include;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\include;" + pathRogue + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <ReferencePath>$(ReferencePath);" + pathXceed + "\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <LibraryPath>$(LibraryPath);" + pathCodjock + "\\" + codejockpath3 + ";" + pathRogue + "\\" + Rockwavepath22 + "</LibraryPath>");
            text.Add("  </PropertyGroup>");
            text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
            text.Add("    <SourcePath>$(SourcePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Src;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
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
            }
            else
            {
                text.Add("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                text.Add("<Project DefaultTargets=\"Build\" ToolsVersion=\"4.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <ExecutablePath>$(ExecutablePath);" + pathCodjock + "\\" + Codejockpath2 + ";" + pathRogue + "\\" + Rockwavepath12 + "</ExecutablePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <IncludePath>$(IncludePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Include;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\include;" + pathRogue + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <ReferencePath>$(ReferencePath);" + pathXceed + "\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <LibraryPath>$(LibraryPath);" + pathCodjock + "\\" + codejockpath3 + ";" + pathRogue + "\\" + Rockwavepath12 + ";" + pathRogue + "\\" + Rockwavepath22 + "</LibraryPath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <SourcePath>$(SourcePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Src;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) == \'\'\">");
                text.Add("    <ExcludePath>$(ExcludePath)</ExcludePath>");
                text.Add("  </PropertyGroup>");
                // !=

                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
                text.Add("    <ExecutablePath>$(ExecutablePath);" + pathCodjock + "\\" + Codejockpath2 + ";" + pathRogue + "\\" + Rockwavepath22 + "</ExecutablePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
                text.Add("    <IncludePath>$(IncludePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Include;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\include;" + pathRogue + "\\" + Rockwavepath1 + "\\RWUXTheme\\Include</IncludePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
                text.Add("    <ReferencePath>$(ReferencePath);" + pathXceed + "\\Xceed DataGrid for WPF v2.0\\Bin</ReferencePath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
                text.Add("    <LibraryPath>$(LibraryPath);" + pathCodjock + "\\" + codejockpath3 + ";" + pathRogue + "\\" + Rockwavepath12 + ";" + pathRogue + "\\" + Rockwavepath22 + "</LibraryPath>");
                text.Add("  </PropertyGroup>");
                text.Add(" <PropertyGroup Condition=\"$(WindowsSDK_LibraryPath_x86) != \'\'\">");
                text.Add("    <SourcePath>$(SourcePath);" + pathCodjock + "\\" + Codejockpath + "\\Source;" + pathRogue + "\\" + Rockwavepath1 + "\\Src;" + pathRogue + "\\" + Rockwavepath1 + "\\Regex\\src</SourcePath>");
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
            }

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

        public  void Update_MSBUILD(string RockwavePath, string CodjocksoftwarePath, int version ,string Rogue,string Codjock)
        {
            string Rockwavepath1 = "", Rockwavepath2 = "";
            switch (version)
            {
                case 7200: Rockwavepath1 = Rogue + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = Codjock + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = Rogue + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7500: Rockwavepath1 = Rogue + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = Codjock + "\\" + CodjocksoftwarePath + "\\Bin\\vc120"; Rockwavepath2 = Rogue + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7530: Rockwavepath1 = Rogue + "\\" + RockwavePath + "\\Bin"; CodjocksoftwarePath = Codjock + "\\" + CodjocksoftwarePath + "\\Bin\\vc120x64"; Rockwavepath2 = Rogue + "\\" + RockwavePath + "\\lib\\vc12\\x64"; break;
                case 7300: Rockwavepath1 = Rogue + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = Codjock + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = Rogue + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;
                case 7400: Rockwavepath1 = Rogue + "\\" + RockwavePath + "\\Lib"; CodjocksoftwarePath = Codjock + "\\" + CodjocksoftwarePath + "\\Bin\\vc100"; Rockwavepath2 = Rogue + "\\" + RockwavePath + "\\Regex\\lib\\VC6"; break;


            }

            const string name = "PATH";
            string url = Rockwavepath1 + ";" + Rockwavepath2 + ";" + CodjocksoftwarePath;
            var target = EnvironmentVariableTarget.User;
            string pathvar = System.Environment.GetEnvironmentVariable(name,target);
            if (!pathvar.Contains(url)) { 
                var value = pathvar + @";" + url;

                System.Environment.SetEnvironmentVariable(name, value,target);
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
