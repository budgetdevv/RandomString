## .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
```assembly
; Benchmark.Benchmark.RandomStringsUsingStringDotCreateConstAlphaStaticRandom()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+8]
       mov       rcx,244F28D72B8
       mov       r9,[rcx]
       test      r9,r9
       jne       short M00_L00
       mov       rcx,offset MT_System.Buffers.SpanAction`2[[System.Char, System.Private.CoreLib],[System.Random, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,244F28D72B0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmark.Benchmark+<>c.<RandomStringsUsingStringDotCreateConstAlphaStaticRandom>b__7_0(System.Span`1<Char>, System.Random)
       mov       [rdi+18],rdx
       mov       rcx,244F28D72B8
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,rdi
M00_L00:
       mov       edx,64
       mov       r8,rsi
       mov       rcx,offset MD_System.String.Create(Int32, !!0, System.Buffers.SpanAction`2<Char,!!0>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Create[[System.__Canon, System.Private.CoreLib]](Int32, System.__Canon, System.Buffers.SpanAction`2<Char,System.__Canon>)
; Total bytes of code 132
```
```assembly
; Benchmark.Benchmark+<>c.<RandomStringsUsingStringDotCreateConstAlphaStaticRandom>b__7_0(System.Span`1<Char>, System.Random)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,r8
       mov       rdi,[rdx]
       mov       ebx,[rdx+8]
       xor       ebp,ebp
       test      ebx,ebx
       jle       short M01_L01
       mov       rcx,244F28D9FC0
       mov       r14,[rcx]
M01_L00:
       mov       r15d,ebp
       mov       rcx,rsi
       xor       edx,edx
       mov       r8d,45
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       cmp       eax,45
       jae       short M01_L02
       mov       eax,eax
       movzx     eax,word ptr [r14+rax*2+0C]
       mov       [rdi+r15*2],ax
       inc       ebp
       cmp       ebp,ebx
       jl        short M01_L00
M01_L01:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 107
```
```assembly
; System.String.Create[[System.__Canon, System.Private.CoreLib]](Int32, System.__Canon, System.Buffers.SpanAction`2<Char,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rdi,rdi
       je        short M02_L01
       test      esi,esi
       jg        short M02_L00
       test      esi,esi
       jne       short M02_L02
       mov       rax,244F28D3020
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       [rsp+28],rcx
       mov       [rsp+30],esi
       mov       rcx,[rdi+8]
       lea       rdx,[rsp+28]
       mov       r8,rbx
       call      qword ptr [rdi+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,1671
       mov       rdx,7FFF8F724000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      <PrivateImplementationDetails>.Throw(System.String)
       int       3
M02_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,57
       mov       rdx,7FFF8F724000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 199
```

## .NET Core 7.0.0 (CoreCLR 7.0.22.15202, CoreFX 7.0.22.15202), X64 RyuJIT
```assembly
; Benchmark.Benchmark.RandStrTrumpMcD2()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,[rcx+8]
       mov       rcx,1F7180072C0
       mov       r9,[rcx]
       test      r9,r9
       jne       short M00_L00
       mov       rcx,offset MT_System.Buffers.SpanAction`2[[System.Char, System.Private.CoreLib],[System.Random, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F7180072B0
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset Benchmark.Benchmark+<>c.<RandStrTrumpMcD2>b__10_0(System.Span`1<Char>, System.Random)
       mov       [rdi+18],rdx
       mov       rcx,1F7180072C0
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,rdi
M00_L00:
       mov       edx,64
       mov       r8,rsi
       mov       rcx,offset MD_System.String.Create(Int32, !!0, System.Buffers.SpanAction`2<Char,!!0>)
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Create[[System.__Canon, System.Private.CoreLib]](Int32, System.__Canon, System.Buffers.SpanAction`2<Char,System.__Canon>)
; Total bytes of code 132
```
```assembly
; Benchmark.Benchmark+<>c.<RandStrTrumpMcD2>b__10_0(System.Span`1<Char>, System.Random)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,r8
       mov       rcx,1F718009FC0
       mov       rdi,[rcx]
       add       rdi,0C
       mov       rbx,[rdx]
       lea       rbp,[rbx+0C8]
       cmp       rbx,rbp
       je        short M01_L01
       cmp       [rsi],esi
       mov       rcx,[rsi]
       mov       r14,[rcx+40]
M01_L00:
       mov       rcx,rsi
       mov       r8d,45
       xor       edx,edx
       call      qword ptr [r14+30]
       cdqe
       movzx     eax,word ptr [rdi+rax*2]
       mov       [rbx],ax
       add       rbx,2
       cmp       rbx,rbp
       jne       short M01_L00
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 98
```
```assembly
; System.String.Create[[System.__Canon, System.Private.CoreLib]](Int32, System.__Canon, System.Buffers.SpanAction`2<Char,System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       esi,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rdi,rdi
       je        short M02_L01
       test      esi,esi
       jg        short M02_L00
       test      esi,esi
       jne       short M02_L02
       mov       rax,1F718003020
       mov       rax,[rax]
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       [rsp+28],rcx
       mov       [rsp+30],esi
       mov       rcx,[rdi+8]
       lea       rdx,[rsp+28]
       mov       r8,rbx
       call      qword ptr [rdi+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,1671
       mov       rdx,7FFF8F724000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      <PrivateImplementationDetails>.Throw(System.String)
       int       3
M02_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,57
       mov       rdx,7FFF8F724000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 199
```
