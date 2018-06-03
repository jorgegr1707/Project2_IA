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
			basicCommands();
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

		
		public void basicCommands()
		{
			commands.Add("Load Agents");
			commands.Add("Load Services Orders");
			commands.Add("Load Default File");
			commands.Add("Show Agents");
			commands.Add("Show Services Orders");
			commands.Add("Distribute");
			commands.Add("Exit");
			commands.Add("Cancel"); 
		}

	}
}
