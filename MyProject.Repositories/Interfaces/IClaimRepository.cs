using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    interface IClaimRepository
    {
        List<Claim> GetAll();

        Claim GetById(int id);

        Claim Add(int id, string name);

        Claim Update(Claim role);

        void Delete(int id);
    }
}
