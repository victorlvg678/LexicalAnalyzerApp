namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState11 : LexicalStateBase
    {
        #region constructors
        public LexicalState11(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == '&')
            {
                _lexicalAnalyzer.changeState(new LexicalState12(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}