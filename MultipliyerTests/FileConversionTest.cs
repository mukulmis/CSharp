﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultipliyerTests
{
    [TestClass]
    public class FileConversionTest
    {
        [TestMethod]
        public void mattias_asplund_1971()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("mattias;asplund;1971");
            Assert.AreEqual("MATTIAS ASPLUND ÄR 46 ÅR GAMMAL.", actual);
        }
        [TestMethod]
        public void amanda_asplund_2003()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("amanda;asplund;2003");
            Assert.AreEqual("AMANDA  ASPLUND ÄR 14 ÅR GAMMAL.", actual);
        }
    }
}
