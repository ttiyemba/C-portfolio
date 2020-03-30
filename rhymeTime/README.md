# Does rhyme 

DoesRhyme("Sam I am!", "Green eggs and ham.") ➞ true
DoesRhyme("Sam I am!", "Green eggs and HAM.") ➞ true
// Capitalization and punctuation should not matter.
DoesRhyme("You are off to the races", "a splendid day.") ➞ false
DoesRhyme("and frequently do?", "you gotta move.") ➞ false

Notes


	
Case insensitive.
	Here we are disregarding cases like "thyme" and "lime".
	We are also disregarding cases like "away" and "today" (which technically rhyme, even though they contain different vowels).
