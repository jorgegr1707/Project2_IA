using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Collections.Generic;

namespace RepairDistribution
{
	class VoiceAgent
	{
		public SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();
		public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
		private List<string> commands = new List<string>();
		private static VoiceAgent voiceAgent = null;

		public VoiceAgent()
		{
			
		}

		//using the singleton pattern can have a better performance when speaking and recognizing
		public static VoiceAgent Instance
		{
			get
			{
				if (null == voiceAgent)
				{
					voiceAgent = new VoiceAgent(); 
				}
				return voiceAgent; 
			}
		}

		public void setListener(SpeechRecognitionEngine listener)
		{
			recognizer = listener;
		}

		public SpeechRecognitionEngine getListener()
		{
			return recognizer; 
		}


	}
}
