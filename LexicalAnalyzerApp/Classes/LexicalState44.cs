namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState44 : LexicalStateBase
    {
        #region constructors
        public LexicalState44(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
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