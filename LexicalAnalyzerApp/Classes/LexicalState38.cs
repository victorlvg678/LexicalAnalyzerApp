namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState38 : LexicalStateBase
    {
        #region constructors
        public LexicalState38(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'a')
            {
                _lexicalAnalyzer.changeState(new LexicalState39(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'b' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}