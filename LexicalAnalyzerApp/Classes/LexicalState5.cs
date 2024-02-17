namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState5 : LexicalStateBase
    {
        #region constructors
        public LexicalState5(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
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