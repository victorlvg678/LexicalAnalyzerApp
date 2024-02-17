namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState6 : LexicalStateBase
    {
        #region constructors
        public LexicalState6(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == '=')
            {
                _lexicalAnalyzer.changeState(new LexicalState44(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}