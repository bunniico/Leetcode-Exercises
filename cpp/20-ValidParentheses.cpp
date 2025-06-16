#include <string>
#include <stack>
#include <unordered_map>
class Solution {
public:
    bool isValid(std::string s) {
        if (s.empty()) return false;

        std::unordered_map<char, char> valid_pairs = {
            {'[', ']'},
            {'{', '}'},
            {'(', ')'}
        };

        // First character must be an opening bracket
        if (valid_pairs.find(s[0]) == valid_pairs.end()) {
            return false;
        }

        // Must have an even number of characters
        if (s.length() % 2 != 0) {
            return false;
        }

        std::stack<char> expected_stack;
        expected_stack.push(valid_pairs[s[0]]);

        for (size_t i = 1; i < s.length(); ++i) {
            char c = s[i];
            if (valid_pairs.find(c) != valid_pairs.end()) {
                expected_stack.push(valid_pairs[c]);
            } else if (!expected_stack.empty() && c == expected_stack.top()) {
                expected_stack.pop();
            } else {
                return false;
            }
        }

        return expected_stack.empty();
    }
};