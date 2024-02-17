namespace LexicalAnalyzerApp.Classes
{
    public abstract class LexicalStateBase
    {
        #region protected members
        protected readonly LexicalAnalyzer _lexicalAnalyzer;
        #endregion

        #region constructors
        public LexicalStateBase(LexicalAnalyzer lexicalAnalyzer)
        {
            _lexicalAnalyzer = lexicalAnalyzer;
        }
        #endregion

        #region public methods
        public abstract void getNextState(char symbol);
        #endregion
    }
}