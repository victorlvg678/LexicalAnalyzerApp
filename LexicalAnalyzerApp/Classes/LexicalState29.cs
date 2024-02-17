namespace LexicalAnalyzerApp.Classes
{
    public class LexicalState29 : LexicalStateBase
    {
        #region constructors
        public LexicalState29(LexicalAnalyzer lexicalAnalyzer) : base(lexicalAnalyzer)
        {

        }
        #endregion

        #region public methods
        public override void getNextState(char symbol)
        {
            if (symbol == 'r')
            {
                _lexicalAnalyzer.changeState(new LexicalState30(_lexicalAnalyzer));
                return;
            }

            if ((symbol >= 'a' && symbol <= 'q') || (symbol >= 's' && symbol <= 'z') || (symbol >= '0' && symbol <= '9'))
            {
                _lexicalAnalyzer.changeState(new LexicalState41(_lexicalAnalyzer));
                return;
            }

            _lexicalAnalyzer.changeState(new LexicalStateInvalid(_lexicalAnalyzer));
        }
        #endregion
    }
}