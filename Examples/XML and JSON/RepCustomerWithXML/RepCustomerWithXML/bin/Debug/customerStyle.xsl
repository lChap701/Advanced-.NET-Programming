<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
   <html>
      <h1>Customers</h1> 
      <table border="3">
      <tr bgcolor="lightblue">
         <th>Customer Number</th> 
         <th>Customer Name</th> 
		<th>Customer Phone</th> 		 
		 <th>Customer Rep</th>  
      </tr>
      <xsl:for-each select="ArrayOfListing/Listing">
      <tr>
         <td>
            <xsl:value-of select="CNum" /> 
         </td>
         <td>
            <xsl:value-of select="CName" /> 
         </td>
		 <td>
            <xsl:value-of select="CPhone" /> 
         </td>
		 <td>
            <xsl:value-of select="CRepName" /> 
         </td>
     </tr>
     </xsl:for-each>
     </table>
   </html>
</xsl:template>
</xsl:stylesheet>