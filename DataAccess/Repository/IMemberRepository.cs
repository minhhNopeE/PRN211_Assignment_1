using BusinessObject;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public List<MemberObject> GetListAllMember(bool descending = false);
        public MemberObject GetMemberByID(int id, List<MemberObject> list);
        public MemberObject GetMemberByEmailAndPassword(string email, string password);
        public void InsertMember(MemberObject member);
        public void UpdateMember(MemberObject updatedMember);
        public void DeleteMember(int id);
        public List<MemberObject> SearchMemberByID(int id, List<MemberObject> list);
        public List<MemberObject> SearchMemberByName(string name, List<MemberObject> list);
        public List<MemberObject> FilterByCity(string city, List<MemberObject> list);
        public List<MemberObject> FilterByCountry(string country, List<MemberObject> list);
    }
}
