using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {
	private static string[] wordList = {"computational","media","art","encyclopedic","participatory","procedural","spatial","machine","robot","hacking","cyber","bitcoin","ethereum","cryptocurrency","digital","privacy","data","algorithms","analytics","security","creative","virtual","augmented","reality","network","social","arduino","coding","games", "apple", "banana", "orange", "grape", "red", "green", "blue", "yellow", "cat", "dog", "bird", "fish", "happy", "sad", "angry", "excited", "mountain", "river", "forest", "ocean", "sunshine", "rain", "snow", "wind", "adventure", "ambition", "apathy", "appreciation", "architect", "astronaut", "atmosphere", "authentic", "autumn", "awkward", "balance", "beauty", "belief", "benevolence", "bewilderment", "biography", "bizarre", "blossom", "boisterous", "bravery", "brilliant", "calmness", "capacity", "catastrophe", "celebration", "certainty", "chaos", "character", "charm", "clarity", "classic", "colossal", "comfort", "communication", "compassion", "complexity", "confidence", "confusion", "consciousness", "consequence", "constellation", "courage", "creativity", "criticism", "crucial", "curiosity", "cynicism", "danger", "darkness", "dawn", "deception", "decision", "dedication", "defiance", "delight", "democracy", "despair", "destiny", "destruction", "determination", "devastation", "devotion", "dialogue", "difficulty", "diligence", "diplomacy", "disappointment", "discipline", "discovery", "disgust", "distraction", "diversity", "doubt", "dream", "drought", "eagerness", "eclectic", "economy", "education", "elegance", "embarrassment", "empathy", "emotion", "endurance", "energy", "enthusiasm", "environment", "equality", "escape", "eternity", "evidence", "evolution", "excellence", "excitement", "existence", "experience", "experiment", "exploration", "extinction", "extraordinary"};
	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}
}