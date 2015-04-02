using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class RoleService
    {
        private RoleRepository roleRepository;

        public RoleService()
        {
            roleRepository = new RoleRepository();
        }

        public List<Role> Get()
        {
            return roleRepository.Get();
        }

        public void Post(Role role)
        {
            roleRepository.Post(role);
        }
    }
}
