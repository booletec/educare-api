using Reluco.ReComex.Domain.Entities;
using System;

namespace Reluco.NewSchool.Domain.Entities.Escola
{
    public class Audit : BaseEntity
    {

        public Guid ObjectId { get; set; }
        public string Action { get; set; }
       
    }
}
