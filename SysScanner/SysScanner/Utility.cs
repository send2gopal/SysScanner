using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SysScanner
{

    public static class Utility
    {

        public static string GetJoinedDomain()
        {
            return "Gopal";
        }

        public static IEnumerable<string> VisibleComputers(bool workgroupOnly = false)
        {
            Func<string, IEnumerable<DirectoryEntry>> immediateChildren = key => new DirectoryEntry("WinNT:" + key)
                    .Children
                    .Cast<DirectoryEntry>();
            Func<IEnumerable<DirectoryEntry>, IEnumerable<string>> qualifyAndSelect = entries => entries.Where(c => c.SchemaClassName == "Computer")
                    .Select(c => c.Name);
            return (
                !workgroupOnly ?
                    qualifyAndSelect(immediateChildren(String.Empty)
                        .SelectMany(d => d.Children.Cast<DirectoryEntry>()))
                    :
                    qualifyAndSelect(immediateChildren("//WORKGROUP"))
            ).ToArray();
        }
    }
}
