﻿using DataAccessLayerSR.Abstract;
using DataAccessLayerSR.Concrete;
using DataAccessLayerSR.Repositories;
using EntityLayerSR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerSR.EntityFramework
{
    public class EfSocialMediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(SignalRContext context) : base(context)
        {
        }
    }
}
