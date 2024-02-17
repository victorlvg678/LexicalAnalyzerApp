namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState2 : LexicalStateBase
    {
        #region constructors
        public LexicalState2(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol >= '0' && symbol <= '9')
            {
                _lexicalAnalyzer.changeState(new LexicalState3(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}