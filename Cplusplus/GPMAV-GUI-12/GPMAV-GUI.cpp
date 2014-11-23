/*
* Clamav GUI Wrapper
*
* Copyright (c) 2006-2009 Gianluigi Tiesi <sherpya@netfarm.it>
*
* Modified by GPM (c) 2010-2014
*
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU Library General Public
* License as published by the Free Software Foundation; either
* version 2 of the License, or (at your option) any later version.
*
* This library is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
* Library General Public License for more details.
*
* You should have received a copy of the GNU Library General Public
* License along with this software; if not, write to the
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
* Modified by Gian ( GPM Antivirus Software GUI)
*/

#include <GPMAV-GUI.h>
#include <shlobj.h>
#include <resource.h>
#include <string>
#include <windows.h>
#include <stdlib.h>
#include <cstdlib>
#include <iostream>
#include <string.h>
#include <fstream>
#include "Shlwapi.h"
#include <io.h>

using namespace std;


#define INIFILE  ".\\GPMAV-Scan.ini"

HWND MainDlg;
BOOL isScanning = FALSE;
HANDLE LogMutex;

#define MAX_OUTPUT 8192
//FROM: https://stackoverflow.com/questions/4130180/how-to-use-vs-c-getenvironmentvariable-as-cleanly-as-possible




/*
std::string cmdArg;
std::string sample2 = "";
std::string strcmd1 = "--log=";
std::string strcmd2 =  WinGetEnv("HOMEDRIVE");
std::string strcmd3 = "\GPMAV\logs\GPMCNScan.log";
*/

/*

const char * databasedir()
{
	//const DWORD buffSize = 65535;
   // static char buffer[buffSize];

	//if (GetEnvironmentVariableA("temp", buffer, buffSize))
		//GetEnvironmentVariableA("temp", buffer, buffSize);
   // {

	char tstrFinal[65535];
	char tstrSec[65535];

	char stringtest3[65535];
	char stringtest4[65535];

	
	const DWORD buffSize1 = 65535;
    static char buffer1[buffSize1];
    GetEnvironmentVariableA("homedrive", buffer1, buffSize1);

   	strcpy(stringtest4, buffer1); //Second
	strcpy(stringtest3, " --database="""); // Copies first string

	strcat(stringtest3, stringtest4);


	strcpy(tstrSec,"\\GPMAV\\database " ); //second
	strcpy(tstrFinal, stringtest3); //first

	strcat(tstrFinal, tstrSec);


        return tstrFinal;

   // }
   // else
   // {
   //     return 0;
   // }
	//return
}

 const char * log()
{
	//const DWORD buffSize = 65535;
   // static char buffer[buffSize];

	//if (GetEnvironmentVariableA("temp", buffer, buffSize))
		//GetEnvironmentVariableA("temp", buffer, buffSize);
   // {

	char tstrFinal1[65535];
	char tstrSec1[65535];

	char stringtest6[65535];
	char stringtest7[65535];

	
   	strcpy(stringtest7, WinGetEnv("homedrive")); //Second
	strcpy(stringtest6, " --log="""); // Copies first string

	strcat(stringtest6, stringtest7);


	strcpy(tstrSec1,"\\GPMAV\\Logs\\GPMCNScan.log " ); //second
	strcpy(tstrFinal1, stringtest6); //first

	strcat(tstrFinal1, tstrSec1);


        return tstrFinal1;

   // }
   // else
   // {
   //     return 0;
   // }
	//return
}
 
const char * Quarantine()
{
	//const DWORD buffSize = 65535;
   // static char buffer[buffSize];

	//if (GetEnvironmentVariableA("temp", buffer, buffSize))
		//GetEnvironmentVariableA("temp", buffer, buffSize);
   // {

	char tstrFinal2[65535];
	char tstrSec2[65535];

	char stringtest8[65535];
	char stringtest9[65535];

	
   	strcpy(stringtest9, WinGetEnv("homedrive")); //Second
	strcpy(stringtest8, " --move="""); // Copies first string

	strcat(stringtest8, stringtest9);


	strcpy(tstrSec2,"\\GPMAV\\Quarantine " ); //second
	strcpy(tstrFinal2, stringtest8); //first

	strcat(tstrFinal2, tstrSec2);

	
        return tstrFinal2;

   // }
   // else
   // {
   //     return 0;
   // }
	//return
}
*
const char * tempdir()
{
	//const DWORD buffSize = 65535;
   // static char buffer[buffSize];
	//if (GetEnvironmentVariableA("temp", buffer, buffSize))
		//GetEnvironmentVariableA("temp", buffer, buffSize);
   // {
	//char testStringFinal[32727];
	//char testString211[32727];
	char stringtest1[65535];
	char stringtest2[65535];
   	strcpy(stringtest2,WinGetEnv("temp")); //Second
	strcpy(stringtest1,"--tempdir="""); // Copies first string
	strcat(stringtest1, stringtest2);
	//strcpy(testStringFinal, testString11);
	//strcpy(testString211, """")
	//strcat(testStringFinal, testString211);
        return stringtest1;

   // }
   // else
   // {
   //     return 0;
   // }
	//return
}*/

//const char  * pap = "\\GPMAV\\database";
//const char * drv =  getenv("homedrive");

typedef struct _Option
{
    const char *param;
    UINT dialog;

} Option;



static Option options[] =
{
	
    { "--recursive",    IDC_RECURSE					},
    { "--remove",       IDC_RADIO1					},
    { "-i",             IDC_ONLYINFECTED			},

    { "--no-summary ",  IDC_NOSUMMARY				},
    { "--bell",			IDC_BEEP					},
	{ " ",				IDC_REPORT					},
	{ "--database=""""./database""",        IDC_db  },
	{ "--quiet",        IDC_QUIET					},
	{ "--log=""""./logs/GPMCNScan.log""",  IDC_LOG  },
    { "--debug",		 IDC_DEBUG					},
    { "--move=""""./quarantine""",     IDC_RADIO2   },
    { "--tempdir=""""./temp""",		   IDC_TEMP		}, //tempdir(),   IDC_TEMP      },
	{ "--verbose", IDC_EXVERBOSE					},
	{"--leave-temps=yes", IDC_EXDONOTREMTEMP		},
	{"--official-db-only=yes", IDC_LOADONLYODB		},
	{"--detect-pua=yes", IDC_DETECTPUA				},
	{"--detect-broken=yes", IDC_DETECTBROKENEXE		},
	{"--block-encrypted=yes", IDC_BLOCKENCARCH		},
	{"--max-filesize=200M", IDC_DONOTSCAN150		},
	{"--scan-mail=yes", IDC_SCANMAIL				},
	{"--algorithmic-detection=yes", IDC_USEALGO		},
	{"--max-recursion=50", IDC_MAXRECUR				},
	{"--max-files=500", IDC_MAXFILES				},
	{"--max-scansize=150M", IDC_MAXFILESIZE			},

    { NULL, 0 }
	
};

const char * WinGetEnv(const char * name)
{

    const DWORD buffSize = 65535;
    static char buffer[buffSize];
    if (GetEnvironmentVariableA(name, buffer, buffSize))
    { 
        return buffer;
    }
    else
    {
        return 0;
    }
}


void GetDestinationFolder(void)
{
    BROWSEINFO pbi;
    char szPath[MAX_PATH];
    LPITEMIDLIST pidlTarget = NULL;
    ZeroMemory(&pbi, sizeof(pbi));

    pbi.hwndOwner = MainDlg;
    pbi.lpszTitle = "Select Target Folder\0";
    pbi.ulFlags = BIF_RETURNONLYFSDIRS | BIF_NONEWFOLDERBUTTON | BIF_NEWDIALOGSTYLE | BIF_USENEWUI;

    pidlTarget = SHBrowseForFolder(&pbi);
    if (pidlTarget && SHGetPathFromIDList(pidlTarget, szPath))
        SetWindowText(GetDlgItem(MainDlg, IDC_TARGET), szPath);
}

void WriteStdOut(LPSTR msg, BOOL freshclam)
{
    char *firstline = NULL;
    WaitForSingleObject(LogMutex, INFINITE);
    HWND editw = GetDlgItem(MainDlg, IDC_STATUS);

    char *buff = 0, *buf = 0;
    int length = GetWindowTextLength(editw);
    length++;
    size_t slen = strlen(msg) + 2;

    buff = buf = new char[length + slen];
    if(!buf) return;

    GetWindowText(editw, buf, length);
    buf[length - 1] = 0;

    if(length > MAX_OUTPUT)
    {
        firstline = strstr(buf, "\r\n");
        if (firstline) firstline += 2;
        buf = firstline;
    }

    if (!buf)
    {
        delete buff;
        SetWindowText(editw, "");
        ReleaseMutex(LogMutex);
        return;
    }

    strcat(buf, msg);
    std::string out;
    if (freshclam)
    {
        char o[2], *m, *m1;
        o[1] = 0;
        for (m = buf; *m; m++)
        {
            m1 = m + 1;
            if ((*m == '\r') && (!m1 || (*m1 != '\n')))
                out.append("\r\n");
            else
            {
                o[0] = *m;
                out.append(o);
            }
        }
    }
    else
        out.append(buf);
    delete buff;

    LockWindowUpdate(editw);
    SetWindowText(editw, out.c_str());
    int lResult = (int) SendMessage(editw, (UINT) EM_GETLINECOUNT, (WPARAM) 0, (LPARAM) 0);
    SendMessage(editw, (UINT) EM_LINESCROLL, (WPARAM) 0, (LPARAM) lResult);
    LockWindowUpdate(NULL);
    ReleaseMutex(LogMutex);
    return;
}

bool fexists(const char *filename)
{
  ifstream ifile(filename);
  return ifile;
}



char *MakeCmdLine(UINT id)
{
    std::string cmdline;
	std::string cmdline1;
    int length = 0;
    int i = 0;


	char testString1[200];
	char testString2[100];



	//const DWORD buffSize = 65535;
    //static char buffer[buffSize];
	//GetEnvironmentVariableA("temp", buffer, buffSize);



/*

			  					cmdline1.append(WinGetEnv("homedrive"));
			cmdline1.append("\\GPMAV\\");
            cmdline1.append(SIGTOOL);
			cmdline1.append(" --info=") ;
			cmdline1.append(WinGetEnv("homedrive"));
			cmdline1.append("\\GPMAV\\database\\main.cvd");
			  						    char *cm1d = new char[cmdline1.size() + 1];
    cm1d[0] = 0;
    strcat(cm1d, cmdline1.c_str());
	*/

    switch (id)
    {
        case IDC_SCAN:
        {
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(CLAMSCAN);
            length = GetWindowTextLength(GetDlgItem(MainDlg, IDC_CMDLINE)) + 1;
            if (length)
            {
                char *useropt = new char[length + 1];
                GetWindowText(GetDlgItem(MainDlg, IDC_CMDLINE), useropt, length);
                useropt[length] = 0;
                cmdline.push_back(' ');
                cmdline.append(useropt);
                delete useropt;
            }

            for (i = 0; options[i].param; i++)
            {
                if (IsDlgButtonChecked(MainDlg, options[i].dialog) == BST_CHECKED)
                {
                    cmdline.push_back(' ');
                    cmdline.append(options[i].param);
                }
            }

            if (!IsDlgButtonChecked(MainDlg, IDC_ALLDRIVES) == BST_CHECKED)
            {
                length = GetWindowTextLength(GetDlgItem(MainDlg, IDC_TARGET));
                if (!length)
                {
                    WriteStdOut("Missing Destination Directory!\r\n", FALSE);
                    return NULL;
                }
                length++;

                char *path = new char[length + 1];
                GetWindowText(GetDlgItem(MainDlg, IDC_TARGET), path, length);
                path[length] = 0;

                cmdline.push_back(' ');
                if (!strchr(path, ' '))
                    cmdline.append(path);
                else
                {
                    cmdline.push_back('"');
                    cmdline.append(path);
                    cmdline.push_back('"');
                }
                delete path;
            }
            else
            {
                char lpBuffer[MAX_PATH], szDrive[MAX_PATH];
                /* Get Drives Mask */
                GetLogicalDriveStrings(MAX_PATH, lpBuffer);
                char *seek = lpBuffer;
                while (*seek)
                {
                    szDrive[0] = 0;
                    strcat(szDrive, seek);
                    seek += strlen(szDrive) + 1;

                    /* Skip Drive A: but not other removable drives */
                    if (tolower(szDrive[0]) == 'a') continue;

                    switch(GetDriveType(szDrive))
                    {
                    case DRIVE_REMOVABLE:
                    case DRIVE_FIXED:
                    case DRIVE_REMOTE:
                    case DRIVE_RAMDISK:
                        cmdline.push_back(' ');
                        cmdline.append(szDrive);
                        break;
                    }
                }
            }
            break;

        }

		       case IDC_SCANMEM:
        {
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(CLAMSCAN);
            length = GetWindowTextLength(GetDlgItem(MainDlg, IDC_CMDLINE)) + 1;
            if (length)
            {
                char *useropt = new char[length + 1];
                GetWindowText(GetDlgItem(MainDlg, IDC_CMDLINE), useropt, length);
                useropt[length] = 0;
                cmdline.push_back(' ');
                cmdline.append(useropt);
                delete useropt;
            }

            for (i = 0; options[i].param; i++)
            {
                if (IsDlgButtonChecked(MainDlg, options[i].dialog) == BST_CHECKED)
                {
                    cmdline.push_back(' ');
                    cmdline.append(options[i].param);
					
                }
            }
			cmdline.append(" ");
			cmdline.append(WinGetEnv ("windir"));


            }
            break;

        case IDC_UPDATE:
			
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(FRESHCLAM);
			cmdline.append(" --stdout --log=");
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\logs\\Autoupdatelog.log""");
			cmdline.append(" --config-file=");
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\gpmavupdate.conf"); //Added 11/22/14
            break;

		case IDC_DISPVDB1:
			 // std::fstream in;
			
			// const char* charVar = WinGetEnv("homedrive");	
			//std::string stdStringVar(charVar);

			//const char* pathm = WinGetEnv("homedrive") ;
			//sss.append(;
			strcpy(testString2,"\\GPMAV\\database\\main.cvd");
			strcpy(testString1,WinGetEnv("homedrive")); // Copies first string
			strcat(testString1, testString2);
    
			 //in.open(sss);
			if(_access(testString1, 0) == -1)
			//if( fexists(endpoint) == 1)
			{
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\main.cld");
			}
			else
			{


			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\main.cvd");
			};




			/*cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\main.cld ");(*/
            break;

		case IDC_DISPVDB2:

		strcpy(testString2,"\\GPMAV\\database\\daily.cvd");
		strcpy(testString1,WinGetEnv("homedrive")); // Copies first string
		strcat(testString1, testString2);

		if( fexists(testString1) == 1)
			{
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\daily.cvd");
						}
			else
			{
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\daily.cld ");
						};
            break;

		case IDC_DISPVDB3:

		strcpy(testString2,"\\GPMAV\\database\\bytecode.cvd");
		strcpy(testString1,WinGetEnv("homedrive")); // Copies first string
		strcat(testString1, testString2);

		if( fexists(testString1) == 1)
			{
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\bytecode.cvd");
									}
			else
			{
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\");
            cmdline.append(SIGTOOL);
			cmdline.append(" --info=") ;
			cmdline.append(WinGetEnv("homedrive"));
			cmdline.append("\\GPMAV\\database\\bytecode.cld ");
									};
            break;
        default:
            return NULL;
    }

    char *cmd = new char[cmdline.size() + 1];
    cmd[0] = 0;
    strcat(cmd, cmdline.c_str());
    return cmd;
}

BOOL CALLBACK EnumChildProc(HWND hwnd, LPARAM lParam)
{
    BOOL save = (BOOL) lParam;
    DWORD id = GetWindowLong(hwnd, GWL_ID);
    char key[5];
    _itoa(id, key, 10);
    switch (id)
    {
        case IDC_TARGET:
        case IDC_CMDLINE:
        {
            char text[MAX_PATH] = "";
            if (save)
            {
                GetWindowText(hwnd, text, MAX_PATH - 1);
                WritePrivateProfileString("dialogs", key, text, INIFILE);
            }
            else
            {
                GetPrivateProfileString("dialogs", key, "", text, MAX_PATH - 1, INIFILE);
                SetWindowText(hwnd, text);
            }
            break;
        }
        case IDC_ALLDRIVES:
        case IDC_RECURSE:
        case IDC_NOARCHIVES:
        case IDC_ONLYINFECTED:
        case IDC_REMOVE:
        case IDC_TEMP:
        //case IDC_BEEP:
        case IDC_NOSUMMARY:
		case IDC_DEBUG:
		//case IDC_db:
		case IDC_QUIET:
		case IDC_LOG:
		//case IDC_PROG:
		//case IDC_UNLOAD:
		case IDC_EXVERBOSE:
		case IDC_EXDONOTREMTEMP:
		case IDC_LOADONLYODB:
		case IDC_DETECTPUA:
		case IDC_DETECTBROKENEXE:
		case IDC_BLOCKENCARCH:
		case IDC_DONOTSCAN150:
		case IDC_SCANMAIL:
		case IDC_USEALGO:
		case IDC_MAXRECUR:
		case IDC_MAXFILES:
		case IDC_MAXFILESIZE:


		case IDC_REPORT:
		case IDC_RADIO1:
		case IDC_RADIO2:
        {
            INT def = (id == IDC_RECURSE) ? 1 : 0;
			
            if (save)
                WritePrivateProfileString("dialogs", key, (IsDlgButtonChecked(MainDlg, id) == BST_CHECKED) ? "1" : "0", INIFILE);
            else
            {
                if (GetPrivateProfileInt("dialogs", key, def, INIFILE))
                    CheckDlgButton(MainDlg, id, 1);
            }
            break; //UNDONE: check default checkbox

        }

        default:
            break;
    }

    return TRUE;
}

INT_PTR CALLBACK DialogProc(HWND hwndDlg, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
    switch(uMsg)
    {
        case WM_INITDIALOG:
        {
            HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON));
            SendMessage(hwndDlg, WM_SETICON, WPARAM(ICON_SMALL), LPARAM (hIcon));
            break;
        }

        case WM_COMMAND:
        {
            if (HIWORD(wParam) == BN_CLICKED)
            {
                switch (LOWORD(wParam))
                {
                    case IDC_SCAN:
                    case IDC_UPDATE:
					case IDC_DISPVDB1:
					case IDC_DISPVDB2:
					case IDC_DISPVDB3:
					case IDC_SCANMEM:
                    {
                        if (isScanning) return true;
                        isScanning = TRUE;
                        DWORD m_dwThreadId;
                        HANDLE m_hThread = CreateThread(NULL, 0, PipeToClamAV, (LPVOID) MakeCmdLine(LOWORD(wParam)), 0, &m_dwThreadId);
                        CloseHandle(m_hThread);
                        break;
                    }

				
		/*case IDC_delreg:
			
					{
						/*shellexecute(".\\regdel.exe")*/
						
/*system("start delreg.exe");*/
						/*ShellExecute(GetDesktopWindow(), "open", "\delreg.exe", NULL, NULL, SW_SHOWNORMAL);*/
						/*shellexecute("delreg.exe");*/



					/*}*/


                    case IDC_CANCEL:
                    {
                        if (!isScanning) return true;
                        if (pi.hProcess != INVALID_HANDLE_VALUE)
                            TerminateProcess(pi.hProcess, -1);
                        break;
                    }
                    case IDC_BROWSE:
                    {
                        if (isScanning) return true;
                        GetDestinationFolder();
                    }
                }
            }
            return true;
        }
        case WM_CLOSE:
        {
            if (pi.hProcess != INVALID_HANDLE_VALUE)
                TerminateProcess(pi.hProcess, -1);
            EnumChildWindows(hwndDlg, EnumChildProc, (LPARAM) TRUE);
            DestroyWindow(hwndDlg);
            return true;
        }
        case WM_DESTROY:
        {
            PostQuitMessage(0);       /* send a WM_QUIT to the message queue */
            return true;
        }
        default:
            return false;
    }
    return true;
}

int APIENTRY WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    MSG msg;
    pi.hProcess = INVALID_HANDLE_VALUE;
    LogMutex = CreateMutex(NULL, FALSE, "ClamAVGuiLoggerMutex");
    MainDlg = CreateDialog(hInstance, MAKEINTRESOURCE(IDD_MAIN), NULL, DialogProc);
    EnumChildWindows(MainDlg, EnumChildProc, (LPARAM) FALSE);

    while (GetMessage(&msg, NULL, 0, 0))
    {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }
    CloseHandle(LogMutex);
    return (int) msg.wParam;
}

