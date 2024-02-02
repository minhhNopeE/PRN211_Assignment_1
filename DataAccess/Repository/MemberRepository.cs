using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public List<MemberObject> GetListAllMember(bool descending = false) 
            => MemberDAO.Instance.GetListAllMember(descending);

        public MemberObject GetMemberByID(int id, List<MemberObject> list) 
            => MemberDAO.Instance.GetMemberByID(id, list);

        public MemberObject GetMemberByEmailAndPassword(string email, string password) 
            => MemberDAO.Instance.GetMemberByEmailAndPassword(email, password);

        public void InsertMember(MemberObject member) 
            => MemberDAO.Instance.InsertMember(member);

        public void UpdateMember(MemberObject updatedMember) 
            => MemberDAO.Instance.UpdateMember(updatedMember);

        public void DeleteMember(int id) 
            => MemberDAO.Instance.DeleteMember(id);

        public List<MemberObject> SearchMemberByID(int id, List<MemberObject> list) 
            => MemberDAO.Instance.SearchMemberByID(id, list);

        public List<MemberObject> SearchMemberByName(string name, List<MemberObject> list) 
            => MemberDAO.Instance.SearchMemberByName(name, list);

        public List<MemberObject> FilterByCity(string city, List<MemberObject> list) 
            => MemberDAO.Instance.FilterByCity(city, list);

        public List<MemberObject> FilterByCountry(string country, List<MemberObject> list) 
            => MemberDAO.Instance.FilterByCountry(country, list);
    }
}
