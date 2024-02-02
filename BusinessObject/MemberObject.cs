using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject
    {
        //check existed email
        private static EmailAddressAttribute checkEmail = new EmailAddressAttribute();
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public MemberObject() { }

        public MemberObject(int memberId, string memberName,
                            string email, string password,
                            string city, string country)
        {
            MemberID = memberId;
            MemberName = memberName;
            Email = email;
            Password = password;
            City = city;
            Country = country;
        }

        public bool IsValid()
        {
            return !(string.IsNullOrWhiteSpace(MemberID.ToString()) || string.IsNullOrWhiteSpace(MemberName) ||
                     string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password));
        }

        public bool IsEmailValid()
        {
            return checkEmail.IsValid(Email);
        }

        protected bool Equals(MemberObject other)
        {
            return MemberID == other.MemberID
                    && string.Equals(MemberName, other.MemberName, StringComparison.CurrentCulture)
                    && string.Equals(Email, other.Email, StringComparison.CurrentCulture)
                    && string.Equals(Password, other.Password, StringComparison.CurrentCulture)
                    && string.Equals(City, other.City, StringComparison.CurrentCulture)
                    && string.Equals(Country, other.Country, StringComparison.CurrentCulture);
        }

        public static bool operator ==(MemberObject left, MemberObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MemberObject left, MemberObject right)
        {
            return !Equals(left, right);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((MemberObject)obj);
        }

        public override int GetHashCode()
        {
            HashCode hashCode = new HashCode();
            hashCode.Add(MemberID);
            hashCode.Add(MemberName, StringComparer.CurrentCulture);
            hashCode.Add(Email, StringComparer.CurrentCulture);
            hashCode.Add(Password, StringComparer.CurrentCulture);
            hashCode.Add(City, StringComparer.CurrentCulture);
            hashCode.Add(Country, StringComparer.CurrentCulture);
            return hashCode.ToHashCode();
        }
    }
}