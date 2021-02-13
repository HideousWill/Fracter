using System.Collections.Generic;

using HideousWorks.Fracter.Common;


namespace HideousWorks.Fracter.ColorTable
{
    public class ColorTableList : List<ColorTableBase>
    {
        //----------------------------------------------------------------------
        public ColorTableList()
        {
            BuildColorTables( 256 );
        }

        //----------------------------------------------------------------------
        void BuildColorTables( int numberOfColors )
        {
            AddRange( Helpers.GetInstancesOfTypesImplementing<ColorTableBase, int>( numberOfColors ) );
        }
    }
}
