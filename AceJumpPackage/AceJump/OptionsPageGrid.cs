using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.VisualStudio.Shell;

namespace AceJumpPackage.AceJump
{
    public class OptionsPageGrid : DialogPage
    {
        private bool isMatchCaseSensitive = false;

        [Category("Acejump Options")]
        [DisplayName("Matching is case-sensitive")]
        [Description("Indicate whether matching of search characters should be case-sensitive")]
        public bool IsMatchCaseSensitive
        {
            get
            {
                return isMatchCaseSensitive;
            }

            set
            {
                isMatchCaseSensitive = value;
            }
        }
    }
}
