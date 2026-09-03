class Solution:
    def isValid(self, s: str) -> bool:
        stack=[]
        hashBrac={')':'(',']':'[','}':'{'} #closing : opening

        for c in s:
            if c in hashBrac:
                if stack and stack[-1]==hashBrac[c]:
                    stack.pop()
                else: return False
            else:
                stack.append(c)
        return True if not stack else False