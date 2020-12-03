using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VetBusiness
    {
        public readonly VetRespository vetRepository;
        public VetBusiness()
        {
            this.vetRepository = new VetRespository();
        }
        public List<Veterinar> GetAllVets()
        {
            return this.vetRepository.GetAllVets();
        }
        public bool InsertVet(Veterinar v)
        {
            if(this.vetRepository.InsertVet(v) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Veterinar> GetVetsExperinece(int experience)
        {
            return this.vetRepository.GetAllVets().Where(v => v.YearsExperience > experience).ToList();
        }
    }
}
