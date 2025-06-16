class Solution:
    def isValid(self, s: str) -> bool:
            input_chars = list(s)
            valid_pairs = {
                '[': ']',
                '{': '}',
                '(': ')'
            }

            # First character must be an opening bracket
            if not input_chars or input_chars[0] not in valid_pairs:
                return False

            # Must have an even number of characters
            if len(input_chars) % 2 != 0:
                return False

            # Stack to track expected closing brackets
            expected_stack = [valid_pairs[input_chars[0]]]

            for char in input_chars[1:]:
                if char in valid_pairs:
                    expected_stack.append(valid_pairs[char])
                elif expected_stack and char == expected_stack[-1]:
                    expected_stack.pop()
                else:
                    return False

            return len(expected_stack) == 0