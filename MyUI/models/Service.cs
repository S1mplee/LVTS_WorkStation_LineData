﻿
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public void CreateScript(string mode,string config,string longviewpath,string solution,int version)
        {
            List<string> script = new List<string>();
            /*
             var target = Argument("target", "Default");

              Task("Default")
              .Does(() =>
       {
          MSBuild(@"C:\Users\MSI\source\repos\DeglaMan\DeglaMan.sln", new MSBuildSettings()
              .UseToolVersion(MSBuildToolVersion.VS2013)
	          .SetConfiguration("Debug")
              .WithTarget("Build")
              .AddFileLogger(new MSBuildFileLogger {
        LogFile = "./log.txt",
        MSBuildFileLoggerOutput = MSBuildFileLoggerOutput.ErrorsOnly,
        PerformanceSummaryEnabled = true,
        AppendToLogFile	= true		
        }));

         });

        RunTarget(target);
             */
            script.Add("var target = Argument(\"target\", \"Default\");");
            script.Add("Task(\"Default\")");
            script.Add("              .Does(() =>");
            script.Add("{");
            var path = Path.Combine(longviewpath, solution);
            string VSTools=String.Empty;
            if (version > 7400)
            {
                VSTools = "VS2013";
            }
            else
            {
                VSTools = "VS2010";
            }
            script.Add("MSBuild(@\"" + path + "\", new MSBuildSettings() ");
            script.Add(".UseToolVersion(MSBuildToolVersion."+VSTools+")");
            script.Add(".SetConfiguration(\"" + mode + "\")");
            if (version < 7530 || mode == "SQL_APPLY_MSFT")
            {
                script.Add(".SetPlatformTarget(PlatformTarget.Win32)");
            }
            else
            {
                script.Add(".SetPlatformTarget(PlatformTarget.x64)");
            }
            script.Add(".WithTarget(\""+config+"\")");
            script.Add(".AddFileLogger(new MSBuildFileLogger {");
            script.Add("LogFile = \"./log.txt\",");
            script.Add("MSBuildFileLoggerOutput = MSBuildFileLoggerOutput.ErrorsOnly,");
            script.Add(" PerformanceSummaryEnabled = true,");
            script.Add("AppendToLogFile	= true");
            script.Add("}));");
            script.Add("  });");
            script.Add("    RunTarget(target);");

            File.WriteAllLines("build.cake", script);

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

        public void CreationDB(string username,string server,string version) {
            string connectionString = "Server="+server+";uid="+username+";pwd=;database=master;Trusted_Connection=Yes;Integrated Security=SSPI";


            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "CREATE DATABASE conf"+version;
                command.ExecuteNonQuery();
                command.CommandText = "CREATE DATABASE gw" + version;
                command.ExecuteNonQuery();
                command.CommandText = "CREATE DATABASE mkt" + version;
                command.ExecuteNonQuery();
            }  

        }

        public void DataBaseScript(string longviewpath,string server,int mode,string version)
        {
            List<string> list = new List<string>();
            string DB= String.Empty;
            if (mode == 0)
            {
                DB = "conf" + version;
            }
            else if (mode == 1)
            {
                DB = "mkt" + version;
            }
            else
            {
                DB = "gw" + version;
            }
            list.Add("BUILD_TYPE=" + mode);
            list.Add("REMOVE_COMMENTS=1");
            list.Add("//Login information used when applying to a Microsoft SQL server database");
            list.Add("SQL_APPLY_MSFT_version=SQL2014");
            list.Add("SQL_APPLY_MSFT_database="+DB);
            list.Add("SQL_APPLY_MSFT_server=" + server);
            list.Add("SQL_APPLY_MSFT_user=");
            list.Add("SQL_APPLY_MSFT_password=");
            list.Add("//Login information used when applying to an Oracle database");
            list.Add("SQL_APPLY_ORACLE_version=ORACLE10g");
            list.Add("SQL_APPLY_ORACLE_server=bs1orc03");
            list.Add("SQL_APPLY_ORACLE_user=lvts_compile");
            list.Add("SQL_APPLY_ORACLE_password=lvts_compile");
            list.Add("//Specifies names of sql files to be generated which can be applied to a database");
            list.Add("SQL_BUILD_OUTPUT_ALL_Msft_Version=SQL2005");
            list.Add("SQL_BUILD_OUTPUT_ALL_Oracle_Version=ORACLE10g");
            list.Add("//Used for ConfigDB database");
            list.Add("SQL_BUILD_OUTPUT_ALL_Msft_ConfigDB_File=msftConfigDB.sql");
            list.Add("SQL_BUILD_OUTPUT_ALL_Oracle_ConfigDB_File=oracleConfigDB.sql");
            list.Add("//Used for Reporting database");
            list.Add("SQL_BUILD_OUTPUT_ALL_Msft_Reporting_File=msftReportingDB.sql");
            list.Add("SQL_BUILD_OUTPUT_ALL_Oracle_Reporting_File=oracleReportingDB.sql");
            list.Add("//Used for building LVTS Database");
            list.Add("SQL_BUILD_OUTPUT_ALL_Msft_Build_File=msftBuild.sql");
            list.Add("SQL_BUILD_OUTPUT_ALL_Oracle_Build_File=oracleBuild.sql");
            list.Add("//Used for marketing data  \r\n SQL_BUILD_OUTPUT_ALL_Msft_Data_File=msftData.sql  \r\n SQL_BUILD_OUTPUT_ALL_Oracle_Data_File=oracleData.sql  \r\n //Used for stp - gwalloc  \r\n SQL_BUILD_OUTPUT_ALL_Msft_gwalloc_File=msftgwallc.sql  \r\n SQL_BUILD_OUTPUT_ALL_Oracle_gwalloc_File=oraclegwalloc.sql  \r\n //Used for stp - gwsrv  \r\n SQL_BUILD_OUTPUT_ALL_Msft_gwsrv_File=msftgwsrv.sql  \r\n SQL_BUILD_OUTPUT_ALL_Oracle_gwsrv_File=oraclegwsrv.sql  \r\n //Used for stp - ioisrv  \r\n SQL_BUILD_OUTPUT_ALL_Msft_ioisrv_File=msftioisrv.sql  \r\n SQL_BUILD_OUTPUT_ALL_Oracle_ioisrv_File=oracleioisrv.sql  \r\n //Used for stp - lqdnet  \r\n SQL_BUILD_OUTPUT_ALL_Msft_lqdnet_File=msftlqdnet.sql  \r\n SQL_BUILD_OUTPUT_ALL_Oracle_lqdnet_File=oraclelqdnet.sql  \r\n //Databases set up just for compiling and not testing  \r\n SQL_COMPILE_MSFT_version=SQL2005  \r\n SQL_COMPILE_MSFT_database=lvts_compile  \r\n SQL_COMPILE_MSFT_server=BS1SQL02\\SQL2K5  \r\n SQL_COMPILE_MSFT_user=  \r\n SQL_COMPILE_MSFT_password=  \r\n SQL_COMPILE_ORACLE_version=ORACLE10g  \r\n SQL_COMPILE_ORACLE_server=bs1orc03  \r\n SQL_COMPILE_ORACLE_user=lvts_compile  \r\n SQL_COMPILE_ORACLE_password=lvts_compile");
            File.WriteAllLines(@longviewpath+"\\Database\\ConfigSqlVars\\SqlVars.txt",list);

            /*
            BUILD_TYPE=1

REMOVE_COMMENTS=1
            
//Login information used when applying to a Microsoft SQL server database
SQL_APPLY_MSFT_version=SQL2014
SQL_APPLY_MSFT_database=mkt7530
SQL_APPLY_MSFT_server=TN1PFE-46
SQL_APPLY_MSFT_user=
SQL_APPLY_MSFT_password=

//Login information used when applying to an Oracle database
SQL_APPLY_ORACLE_version=ORACLE10g
SQL_APPLY_ORACLE_server=bs1orc03
SQL_APPLY_ORACLE_user=lvts_compile
SQL_APPLY_ORACLE_password=lvts_compile

//Specifies names of sql files to be generated which can be applied to a database
SQL_BUILD_OUTPUT_ALL_Msft_Version=SQL2005
SQL_BUILD_OUTPUT_ALL_Oracle_Version=ORACLE10g
//Used for ConfigDB database
SQL_BUILD_OUTPUT_ALL_Msft_ConfigDB_File=msftConfigDB.sql
SQL_BUILD_OUTPUT_ALL_Oracle_ConfigDB_File=oracleConfigDB.sql
//Used for Reporting database
SQL_BUILD_OUTPUT_ALL_Msft_Reporting_File=msftReportingDB.sql
SQL_BUILD_OUTPUT_ALL_Oracle_Reporting_File=oracleReportingDB.sql
//Used for building LVTS Database
SQL_BUILD_OUTPUT_ALL_Msft_Build_File=msftBuild.sql
SQL_BUILD_OUTPUT_ALL_Oracle_Build_File=oracleBuild.sql
//Used for marketing data
SQL_BUILD_OUTPUT_ALL_Msft_Data_File=msftData.sql
SQL_BUILD_OUTPUT_ALL_Oracle_Data_File=oracleData.sql
//Used for stp - gwalloc
SQL_BUILD_OUTPUT_ALL_Msft_gwalloc_File=msftgwallc.sql
SQL_BUILD_OUTPUT_ALL_Oracle_gwalloc_File=oraclegwalloc.sql
//Used for stp - gwsrv
SQL_BUILD_OUTPUT_ALL_Msft_gwsrv_File=msftgwsrv.sql
SQL_BUILD_OUTPUT_ALL_Oracle_gwsrv_File=oraclegwsrv.sql
//Used for stp - ioisrv
SQL_BUILD_OUTPUT_ALL_Msft_ioisrv_File=msftioisrv.sql
SQL_BUILD_OUTPUT_ALL_Oracle_ioisrv_File=oracleioisrv.sql
//Used for stp - lqdnet
SQL_BUILD_OUTPUT_ALL_Msft_lqdnet_File=msftlqdnet.sql
SQL_BUILD_OUTPUT_ALL_Oracle_lqdnet_File=oraclelqdnet.sql

//Databases set up just for compiling and not testing
SQL_COMPILE_MSFT_version=SQL2005
SQL_COMPILE_MSFT_database=lvts_compile
SQL_COMPILE_MSFT_server=BS1SQL02\SQL2K5
SQL_COMPILE_MSFT_user=
SQL_COMPILE_MSFT_password=
SQL_COMPILE_ORACLE_version=ORACLE10g
SQL_COMPILE_ORACLE_server=bs1orc03
SQL_COMPILE_ORACLE_user=lvts_compile
SQL_COMPILE_ORACLE_password=lvts_compile
            */
        }
    }
}
