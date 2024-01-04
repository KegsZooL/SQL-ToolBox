using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using ICSharpCode.AvalonEdit;
using System.Xml;
using System.Diagnostics;

namespace SQLProgram
{
    static class Highlighting
    {   
        public static void SetCustomHighlighting() 
        {
            const string path = "Syntax\\SQL.xshd";


            try 
            {
                using (Stream syntaxStream = new FileStream(path, FileMode.Open)) 
                {
                    using(XmlTextReader xmlReader = new XmlTextReader(syntaxStream)) 
                    {
                        IHighlightingDefinition customHighliting = HighlightingLoader.Load(
                            xmlReader, HighlightingManager.Instance);
                    }
                }   
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
            }    
        }
    }
}