//-----------------------------------------------------------------------------
// Name:        ShellExt.h
// Product:     ClamWin Antivirus
//				GPM Antivirus
//
// Author:      alch [alch at users dot sourceforge dot net]
// Modified:	GPM
//
//				YYYY/DD/MM
// Created:     2004/19/03
// Modified:	2014/06/09
// Copyright:   Copyright alch (c) 2004
// Licence:
//   This program is free software; you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation; either version 2 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program; if not, write to the Free Software
//   Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.

//-----------------------------------------------------------------------------

//
// The class ID of this Shell extension class.
//
// class id:  e76d8ce0-8944-4fed-b363-c2df08724673
//
//

#ifndef _SHELLEXT_H
#define _SHELLEXT_H

#define CF_HDROP        15

// {65713842-C410-4f44-8383-BFE01A398C90}
// {e76d8ce0-8944-4fed-b363-c2df08724673}
DEFINE_GUID(CLSID_ShellExtension,
			//	0x65713842, 0xc410, 0x4f44, 0x83, 0x83, 0xbf, 0xe0, 0x1a, 0x39, 0x8c, 0x90);
				0xe76d8ce0, 0x8944, 0x4fed, 0xb3, 0x63, 0xc2, 0xdf, 0x08, 0x72, 0x46, 0x73);

class CShellExtClassFactory : public IClassFactory
{
protected:
	ULONG	m_cRef;					// Object reference count

public:
	CShellExtClassFactory();
	~CShellExtClassFactory();

	//IUnknown members
	STDMETHODIMP			QueryInterface(REFIID, LPVOID FAR *);
	STDMETHODIMP_(ULONG)	AddRef();
	STDMETHODIMP_(ULONG)	Release();

	//IClassFactory members
	STDMETHODIMP		CreateInstance(LPUNKNOWN, REFIID, LPVOID FAR *);
	STDMETHODIMP		LockServer(BOOL);

};
typedef CShellExtClassFactory *LPCSHELLEXTCLASSFACTORY;

// this is the actual OLE Shell context menu handler
class CShellExt : public IContextMenu,
IShellExtInit
{
protected:
	ULONG			m_cRef;					// Object reference count
	LPDATAOBJECT	m_pDataObj;

public:
	CShellExt();
	~CShellExt();

	//IUnknown members
	STDMETHODIMP			QueryInterface(REFIID, LPVOID FAR *);
	STDMETHODIMP_(ULONG)	AddRef();
	STDMETHODIMP_(ULONG)	Release();

	//IShell members
	STDMETHODIMP			QueryContextMenu(HMENU hMenu, UINT indexMenu,  UINT idCmdFirst, UINT idCmdLast, UINT uFlags);
	STDMETHODIMP			InvokeCommand(LPCMINVOKECOMMANDINFO lpcmi);
    STDMETHODIMP            GetCommandString(UINT_PTR idCmd, UINT uType, UINT *pwReserved, LPSTR pszName, UINT cchMax);
	//IShellExtInit methods
	STDMETHODIMP		    Initialize(LPCITEMIDLIST pIDFolder, LPDATAOBJECT pDataObj, HKEY hKeyID);
private:
    BOOL Scan(HWND hwnd);
	PTCHAR m_szPath;
};
typedef CShellExt *LPCSHELLEXT;

#endif // _SHELLEXT_H
