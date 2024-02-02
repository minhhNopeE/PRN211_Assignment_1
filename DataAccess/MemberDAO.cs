using BusinessObject;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO
    {
        //Initialize member list
        private static List<MemberObject> memberList = new List<MemberObject>() {
            new MemberObject(1, "Pham Thi Ngoc Mai", "maiptnhe163252@fpt.edu.vn", "123456789", "Hanoi", "Vietnam"),
            new MemberObject(2, "Shelagh Brearty", "sbrearty1@netvibes.com", "123456789", "Silvares", "Portugal"),
            new MemberObject(3, "Dare Halladey", "dhalladey2@arstechnica.com", "123456789", "Íos", "Greece"),
            new MemberObject(4, "Cordey Pickle", "cpickle3@intel.com", "123456789", "Dulangan", "Philippines"),
            new MemberObject(5, "Kirby Culmer", "kculmer4@whitehouse.gov", "123456789", "Passos", "Portugal"),
            new MemberObject(6, "Giralda Judron", "gjudron5@merriam-webster.com", "123456789", "Cho-airong", "Thailand"),
            new MemberObject(7, "Teador MacMoyer", "tmacmoyer6@engadget.com", "123456789", "Ban Phan Don", "Thailand"),
            new MemberObject(8, "Lucias Fulcher", "lfulcher7@merriam-webster.com", "123456789", "Piraquara", "Brazil"),
            new MemberObject(9, "Trix Indgs", "tindgs8@chicagotribune.com", "123456789", "Yŏng-dong", "South Korea"),
            new MemberObject(10, "Donavon Webster", "dwebster9@google.ca", "123456789", "Neochórion", "Greece"),
        };

        //using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO()
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string adminEmail = configurationRoot["admin:email"];
            string adminPassword = configurationRoot["admin:password"];
            memberList.Add(new MemberObject(11, "Admin", adminEmail, adminPassword, "Ha Noi", "Viet Nam"));
        }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        //Read - List all member & sort
        public List<MemberObject> GetListAllMember(bool descending = false)
        {
            if (descending)
            {
                return memberList.OrderByDescending(mem => mem.MemberName).ToList();
            }
            else
            {
                return memberList.OrderBy(mem => mem.MemberName).ToList();
            }
        }

        //Read - List all member by email & password
        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            return memberList.SingleOrDefault(member => member.Email.Equals(email)
                && member.Password.Equals(password));
        }

        //Read - List member by id
        public MemberObject GetMemberByID(int id, List<MemberObject> list)
        {
            list ??= memberList;
            return memberList.SingleOrDefault(member => member.MemberID == id);
        }

        //Create - create member
        public void InsertMember(MemberObject member)
        {
            if (GetMemberByID(member.MemberID, null) != null)
            {
                throw new Exception("Member already exists!");
            }
            memberList.Add(member);
        }

        //Update - update member
        public void UpdateMember(MemberObject memberUpdate)
        {
            MemberObject member = GetMemberByID(memberUpdate.MemberID, null);
            if (member == null)
            {
                throw new Exception("Member does not exist!");
            }
            member.MemberName = memberUpdate.MemberName;
            member.Email = memberUpdate.Email;
            member.Password = memberUpdate.Password;
            member.City = memberUpdate.City;
            member.Country = memberUpdate.Country;
        }

        //Delete - delete member
        public void DeleteMember(int id)
        {
            MemberObject member = GetMemberByID(id, null);
            if (member == null)
            {
                throw new Exception("Member does not exist!");
            }
            memberList.Remove(member);
        }

        //Search - search by name (search equal ignore case)
        public List<MemberObject> SearchMemberByName(string name, List<MemberObject> list)
        {
            list ??= memberList;
            return list.Where(member => member.MemberName.ToLower().Contains(name.ToLower())).ToList();
        }

        //Search - search by id
        public List<MemberObject> SearchMemberByID(int id, List<MemberObject> list)
        {
            list ??= memberList;
            return list.Where(member => member.MemberID.ToString().Contains(id.ToString())).ToList();
        }

        //Filter - filter by country
        public List<MemberObject> FilterByCountry(string country, List<MemberObject> list)
        {
            list ??= memberList;
            return list.Where(member => member.Country.Equals(country)).ToList();
        }

        //Filter - filter by city
        public List<MemberObject> FilterByCity(string city, List<MemberObject> list)
        {
            list ??= memberList;
            return list.Where(member => member.City.Equals(city)).ToList();
        }
    }
}