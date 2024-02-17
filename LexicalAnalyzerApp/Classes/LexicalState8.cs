namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState8 : LexicalStateBase
    {
        #region constructors
        public LexicalState8(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}