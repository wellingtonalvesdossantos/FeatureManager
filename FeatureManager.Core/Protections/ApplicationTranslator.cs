using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Protections
{
    public class ApplicationTranslator : IApplicationTranslator
    {
        private readonly IMapper _mapper;

        public ApplicationTranslator(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Translate<TDestination>(object source) => _mapper.Map<TDestination>(source);
        public TDestination Translate<TSource, TDestination>(TSource source) => _mapper.Map<TDestination>(source);
    }
}
