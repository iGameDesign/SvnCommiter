using System;
using System.Collections.Generic;		  					 	
using System.Text;

namespace SvnCommiter		 				 	 	
{
    public class SearchEventArgs : System.EventArgs
    {
        private string replacestring = "";
        private string searchstring = "";
        public static bool Replaceed;		 				 	 	
        public string Searchstring
        {
            get
            {
                return searchstring;
            }
            set
            {
                searchstring = value;
            }
        }			 	 	 	 	
        public string Replacestring
        {		 						 	
            get
            {
                return replacestring;							 	 	
            }
            set
            {									 	
                replacestring = value;
            }									 	
        }
    }
}
