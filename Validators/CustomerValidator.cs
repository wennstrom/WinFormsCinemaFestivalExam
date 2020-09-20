using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class CustomerValidator
    { 
        public bool ValidateName(string name)
        {          
            if (name.Length < 2)
                return false;

            //checks so that name contains letters and common special characters for name only
            var nameRegex = new Regex(@"^[A-Öa-ö-'. ]");
            return nameRegex.IsMatch(name);
        }
        public bool ValidateSSN(string ssn)
        {

            //only accepts ssn with format yyyy/mm/dd-xxxx or yyyy-mm-dd-xxxx
            if (ssn.Length != 15)
                return false;

            var checkSSN = ssn.Replace("-", string.Empty);

            if (checkSSN.Length != 14)
                return false;

            return true;
        }
        public bool ValidateAge(DateTime birthDate)
        {
            var today = DateTime.Now;

            var ageInDays = (today - birthDate).TotalDays;

            //multiplied by 365.25 incase of loop years
            var yearsOld = ageInDays * 365.25;

            return yearsOld > 17 ? true : false;
        }
        public bool ValidateBirthdate(string birthDate)
        {
            try
            {
                DateTime.Parse(birthDate);
            }
            catch
            {
                //date is not valid
                return false;
            }

            return true;
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        { 
            
            var format = phoneNumber.Replace("-", string.Empty);
            format = format.Replace(" ", string.Empty);
            if (format.Length > 4 == false)
                return false;

            //checks so phonenumber only contains digits
            Regex checkNumbersOnly = new Regex(@"^[0-9]*$");
            return checkNumbersOnly.IsMatch(format);
        }
        
    }
}
