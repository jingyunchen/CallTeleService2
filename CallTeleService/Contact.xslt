<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="/">
    <xsl:for-each select="Contacts">
      <xsl:element name="Contacts">
        <xsl:for-each select="Contact">
          <xsl:element name="Contact">
            <xsl:attribute name="title">
              <xsl:value-of select="title"/>
            </xsl:attribute>
            <xsl:attribute name="name">
              <xsl:value-of select="name"/>
            </xsl:attribute>
            <xsl:attribute name="email">
              <xsl:value-of select="email"/>
            </xsl:attribute>
            <xsl:attribute name="org">
              <xsl:value-of select="org"/>
            </xsl:attribute>
            <xsl:attribute name="phone">
              <xsl:value-of select="phone"/>
            </xsl:attribute>
            <xsl:attribute name="country">
              <xsl:value-of select="country"/>
            </xsl:attribute>
            <xsl:attribute name="subject">
              <xsl:value-of select="subject"/>
            </xsl:attribute>
            <xsl:attribute name="secSubject">
              <xsl:value-of select="secSubject"/>
            </xsl:attribute>
            <xsl:attribute name="comment">
              <xsl:value-of select="comment"/>
            </xsl:attribute>
          <xsl:attribute name="dateCreated">
              <xsl:value-of select="dateCreated"/>
            </xsl:attribute>
          </xsl:element>
        </xsl:for-each>
      </xsl:element>
    </xsl:for-each>
  </xsl:template>
</xsl:stylesheet>
