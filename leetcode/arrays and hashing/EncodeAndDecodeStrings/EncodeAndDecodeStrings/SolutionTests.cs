namespace EncodeAndDecodeStrings
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<string> expected = new List<string>() { "Hello", "", "World" };

            List<string> strs = new List<string>() { "Hello", "", "World" };

            Codec codec = new Codec();
            Assert.Equal(expected, codec.decode(codec.encode(strs)));
        }

        [Fact]
        public void Test2()
        {
            List<string> expected = new List<string>() { "" };

            List<string> strs = new List<string>() { "" };

            Codec codec = new Codec();
            Assert.Equal(expected, codec.decode(codec.encode(strs)));
        }

        [Fact]
        public void Test3()
        {
            List<string> expected = new List<string>() { "abc", "defg" };

            List<string> strs = new List<string>() { "abc", "defg" };

            Codec codec = new Codec();
            Assert.Equal(expected, codec.decode(codec.encode(strs)));
        }

        [Fact]
        public void Test4()
        {
            List<string> expected = new List<string>()
            {
                "",
                ";2N;Qj6lX]( lfmW}qr[<++Lh^.nj(kHx+uvF<}4QGSo#:1Ybee=i=*Ibe+9SKGj",
                "-9@d^",
                "X{`~`#P%0a/x~Ze.MtZq#Yb",
                "xTm9~iH/3>OC=n.YeBtv}Z@ol?YRP3oz({lpP1HG?:Q=sv:.9& W?AR_P35sfx_Xh)hU4S^?#}W2c?,u",
                "X`*m`SD,f6.rh",
                "mjV5O2AHnpQo ~96gt-EHHtqwirb1r3V+)EmG,h&$u.e{exz?twL,J7=mB!Dqm#%@FK=Y@DQ9IVxG[NaV",
                ",9,Rhss~`L<8Mv+~I!As5PPDF%rPA~:IwZYKZ5Qfm@;dLT:itEp{V $Uc0P0IAULAkGk !un7y",
                "<oMt2])tZUkOnpM_1~,@Yjj1uN%)XNl<{$2nN2h.^FcF(L`l A}j%u,|va%WT*%fVEi@VLO~,>c5xJ@j9MQ1BNC;xpe3=|bo",
                "{m^r~2mh4u&1AWq?7gXlbN^~&.+o?<z9Jnf*EU`%)(3Ta]f1_o&twc<Tag",
                "np$BV-xU@C/GPNt/+q.<r8TJB#e0N?W_H~7$BV7{W@ Kd2={u{1x+pGr*SmI+~^[r@L]Bk^7#*F{/8|nX32-Qxs&s7>1",
                "+xug]vd459ord^Un3p@F)kG",
                "IY!?%?_6aql8&t+<o-&|Z2s6k8JT|4g@@R?)2}cP?;hMhqeVYxpd.<-J*mfmq@[jSl()Y6`Q<?7/Ciox",
                "K0eU~4@K",
                "jXu/xFHp1LD[=2<RuPPCm<Tt^fptf7ssHdXBR=b`<=m(}}7<325",
                "si %}IJ8fhXZv~oExl(U)h7H=w!{3[",
                "wvtO[v~5vp?@Oef@]@GibBHf?36/E9uSPkRI}a58Vc/Pf>T7k}8?q<_A3w2O(]yx(T%w5cy:* +Pe}l$N#C:aw+EHq5?  %K79C"
            };

            List<string> strs = new List<string>()
            {
                "",
                ";2N;Qj6lX]( lfmW}qr[<++Lh^.nj(kHx+uvF<}4QGSo#:1Ybee=i=*Ibe+9SKGj",
                "-9@d^",
                "X{`~`#P%0a/x~Ze.MtZq#Yb",
                "xTm9~iH/3>OC=n.YeBtv}Z@ol?YRP3oz({lpP1HG?:Q=sv:.9& W?AR_P35sfx_Xh)hU4S^?#}W2c?,u",
                "X`*m`SD,f6.rh",
                "mjV5O2AHnpQo ~96gt-EHHtqwirb1r3V+)EmG,h&$u.e{exz?twL,J7=mB!Dqm#%@FK=Y@DQ9IVxG[NaV",
                ",9,Rhss~`L<8Mv+~I!As5PPDF%rPA~:IwZYKZ5Qfm@;dLT:itEp{V $Uc0P0IAULAkGk !un7y",
                "<oMt2])tZUkOnpM_1~,@Yjj1uN%)XNl<{$2nN2h.^FcF(L`l A}j%u,|va%WT*%fVEi@VLO~,>c5xJ@j9MQ1BNC;xpe3=|bo",
                "{m^r~2mh4u&1AWq?7gXlbN^~&.+o?<z9Jnf*EU`%)(3Ta]f1_o&twc<Tag",
                "np$BV-xU@C/GPNt/+q.<r8TJB#e0N?W_H~7$BV7{W@ Kd2={u{1x+pGr*SmI+~^[r@L]Bk^7#*F{/8|nX32-Qxs&s7>1",
                "+xug]vd459ord^Un3p@F)kG",
                "IY!?%?_6aql8&t+<o-&|Z2s6k8JT|4g@@R?)2}cP?;hMhqeVYxpd.<-J*mfmq@[jSl()Y6`Q<?7/Ciox",
                "K0eU~4@K",
                "jXu/xFHp1LD[=2<RuPPCm<Tt^fptf7ssHdXBR=b`<=m(}}7<325",
                "si %}IJ8fhXZv~oExl(U)h7H=w!{3[",
                "wvtO[v~5vp?@Oef@]@GibBHf?36/E9uSPkRI}a58Vc/Pf>T7k}8?q<_A3w2O(]yx(T%w5cy:* +Pe}l$N#C:aw+EHq5?  %K79C"
            };

            Codec codec = new Codec();
            Assert.Equal(expected, codec.decode(codec.encode(strs)));
        }

        [Fact]
        public void Test5()
        {
            List<string> expected = new List<string>()
            {
                "B!)1s}_!O~2$e1}T`rSoxKQ4$_;<$~7T#to!WrLC&|V/H;NXVCsf~k*}%q",
                "?}*nN)9KTjxa1c.x~$JI9Qt.|CBrB",
                "HBl%yV/%Gd5DuqHK3ks{UBF<rL+q1(U oU^!4kU/qOhy(XF",
                "2#<;nj",
                "St4XG^(TG$U^F2Q6Xd0ZAE7X1i RSpinC/I=zMY3ebGi?9|:9GT.t%6Phxs];m`K#W6Dzy{"
            };

            List<string> strs = new List<string>()
            {
                "B!)1s}_!O~2$e1}T`rSoxKQ4$_;<$~7T#to!WrLC&|V/H;NXVCsf~k*}%q",
                "?}*nN)9KTjxa1c.x~$JI9Qt.|CBrB",
                "HBl%yV/%Gd5DuqHK3ks{UBF<rL+q1(U oU^!4kU/qOhy(XF",
                "2#<;nj",
                "St4XG^(TG$U^F2Q6Xd0ZAE7X1i RSpinC/I=zMY3ebGi?9|:9GT.t%6Phxs];m`K#W6Dzy{"
            };

            Codec codec = new Codec();
            Assert.Equal(expected, codec.decode(codec.encode(strs)));
        }
    }
}