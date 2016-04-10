using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKreations
{
    public class Customer
    {
        /// <summary>
        /// customer / member mailing and card address, email, phone number
        /// </summary>
        #region Customer    
        public int CustNum { get; set; }
        public string CustName { get; set; }
        #region MailingAddress
        public string CustMailAdd1 { get; set; }
        public string CustMailAdd2 { get; set; }
        public string CustMailCity { get; set; }
        public string CustMailState { get; set; }
        public int CustMailZip { get; set; }
        #endregion MailingAddress
        #region CustAddress 
        public string CustAdd1 { get; set; }
        public string CustAdd2 { get; set; }
        public string CustCity { get; set; }
        public string CustState { get; set; }
        public int CustZip { get; set; }
        #endregion CustAddress  
        public string CustEmail1 { get; set; }
        public string CustEmail2 { get; set; }
        public int CustPhone1 { get; set; }
        public int CustPhone2 { get; set; }
        #endregion Customer 


    }
}
