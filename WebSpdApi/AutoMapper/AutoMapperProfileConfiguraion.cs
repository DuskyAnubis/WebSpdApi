using AutoMapper;
using System;
using System.Linq;


namespace WebSpdApi.AutoMapper
{
    public class AutoMapperProfileConfiguraion : Profile
    {
        public AutoMapperProfileConfiguraion()
             : this("MyProfile")
        {

        }

        protected AutoMapperProfileConfiguraion(string profileName) : base(profileName)
        {

        }
    }
}
