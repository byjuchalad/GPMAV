// CustomCommandLineInfo.h: interface for the CCustomCommandLineInfo class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_CUSTOMCOMMANDLINEINFO_H__B11E0AFF_8EA5_4C8D_BBA3_A457452C0F8D__INCLUDED_)
#define AFX_CUSTOMCOMMANDLINEINFO_H__B11E0AFF_8EA5_4C8D_BBA3_A457452C0F8D__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

class CCustomCommandLineInfo : public CCommandLineInfo  
{
public:
//	CCustomCommandLineInfo();
	virtual ~CCustomCommandLineInfo();
	 //virtual void ParseParam(const char* pszParam, BOOL bFlag, BOOL bLast);
CCustomCommandLineInfo()
  {
    m_bExport = m_bOpen = m_bWhatever = FALSE;
  }

  //for convenience maintain 3 variables to indicate the param passed. 
  BOOL m_bExport;       //for /e
  BOOL m_bOpen;         //for /o
  BOOL m_bWhatever;     //for /whatever
 
  //public methods for checking these.
public:
  BOOL IsExport() { return m_bExport; };
  BOOL IsOpen() { return m_bOpen; };
  BOOL IsWhatever() { return m_bWhatever; };
   
  virtual void ParseParam(const char* pszParam, BOOL bFlag, BOOL bLast)
  {
    if(0 == strcmp(pszParam, "/o"))
    {
      m_bOpen = TRUE;
    } 
    else if(0 == strcmp(pszParam, "/e"))
    {
      m_bExport = TRUE;
    }
    else if(0 == strcmp(pszParam, "/whatever"))
    {
      m_bWhatever = TRUE;
    }
  }
};

#endif // !defined(AFX_CUSTOMCOMMANDLINEINFO_H__B11E0AFF_8EA5_4C8D_BBA3_A457452C0F8D__INCLUDED_)
