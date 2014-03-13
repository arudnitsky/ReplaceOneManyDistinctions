using System.Collections.Generic;

namespace ReplaceOneManyDistinctions.Spec
{
   public class CompositeSpec
   {
      private List<ISpec> _specs;

      public CompositeSpec( List<ISpec> specs )
      {
         _specs = specs;
      }

      public List<ISpec> GetSpecs()
      {
         return _specs;
      }
   }
}
