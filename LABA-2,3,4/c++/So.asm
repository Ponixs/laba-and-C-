.text
.global mult
mult(int, int):
        push    rbp
        mov     rbp, rsp
        mov     eax, edi
        mov     edx, esi
        mov     DWORD PTR [rbp-4], 1
        jmp     .L2
.L3:
        add     eax, eax
        sal     DWORD PTR [rbp-4]
.L2:
        cmp     DWORD PTR [rbp-4], edx
        jl      .L3
        pop     rbp
        ret
