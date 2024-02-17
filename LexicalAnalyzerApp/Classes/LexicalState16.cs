namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState16 : LexicalStateBase
    {
        #region constructors
        public LexicalState16(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == '=')
            { 
                _lexicalAnalyzer.changeState(new LexicalState15(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}