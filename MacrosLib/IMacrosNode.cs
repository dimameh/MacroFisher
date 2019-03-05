namespace MacroFisher.MacrosLib
{
    public interface IMacrosNode
    {
        #region Properties

        int Id { get; set; }

        #endregion

        #region Public methods

        void RunNode();

        #endregion
    }
}