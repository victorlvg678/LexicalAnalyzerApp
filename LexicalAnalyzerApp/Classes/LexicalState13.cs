namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState13 : LexicalStateBase
    {
        #region constructors
        public LexicalState13(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == '|')
            {
                _lexicalAnalyzer.changeState(new LexicalState14(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}