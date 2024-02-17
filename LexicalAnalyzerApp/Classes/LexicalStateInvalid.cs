namespace LexicalAnalyzerApp.Classes
{
    public class LexicalStateInvalid : LexicalStateBase
    {
        #region constructors
        public LexicalStateInvalid(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
        }
        #endregion
    }
}