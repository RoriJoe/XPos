using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class MemberService
    {
        MemberRepository memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }

        public List<Member> Get()
        {
            return memberRepository.Get();
        }

        public void Post(Member member)
        {
            memberRepository.Post(member);
        }
    }
}
