using AutoMapper;
using FeatureManager.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Translations
{
    public class TypeProfile : Profile
    {
        public TypeProfile() 
        {
            CreateMap<CPF, string?>()
                .ConstructUsing((origin, destination) => origin?.Value);
            CreateMap<string?, CPF>()
                .ConstructUsing((origin, destination) => new(origin));
            CreateMap<CNPJ, string?>()
                .ConstructUsing((origin, destination) => origin?.Value);
            CreateMap<string?, CNPJ>()
                .ConstructUsing((origin, destination) => new(origin));
            CreateMap<CEP, string?>()
                .ConstructUsing((origin, destination) => origin?.Value);
            CreateMap<string?, CEP>()
                .ConstructUsing((origin, destination) => new(origin));
        }
    }
}
