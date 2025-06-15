class Solution:
    def scoreOfString(self, s: str) -> int:
        chars = [char for char in s]
        ascii = [ord(value) for value in chars]
        abs_value: number = 0
        for index, value in enumerate(ascii):
            if index == len(ascii) - 1:
                return abs_value
            abs_value += abs(ascii[index] - ascii[index + 1])
            pass