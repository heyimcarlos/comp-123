namespace lab5;

[Flags]
public enum GenreEnum
{
    Unrated = 0,               // 0
    Action = 0b1,              // 1
    Comedy = 0b10,             // 2
    Horror = 0b100,            // 4
    Fantasy = 0b1000,          // 8
    Musical = 0b10000,         // 16
    Mystery = 0b100000,        // 32
    Romance = 0b1000000,       // 64
    Adventure = 0b10000000,    // 128
    Animation = 0b100000000,   // 256
    Documentary = 0b1000000000 // 512
}
