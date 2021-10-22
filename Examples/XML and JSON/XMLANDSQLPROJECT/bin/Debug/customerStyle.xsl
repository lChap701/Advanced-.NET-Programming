<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
   <html>
      <h1>Customers</h1> 
      <table border="3">
      <tr bgcolor="lightblue">
         <th>Customer#</th> 
         <th>Name</th>         
      </tr>
      <xsl:for-each select="ArrayOfCustomer/Customer">
      <tr>
         <td>
            <xsl:value-of select="CNum" /> 
         </td>
         <td>
            <xsl:value-of select="CName" /> 
         </td>
     </tr>
     </xsl:for-each>
     </table>
   </html>
</xsl:template>
</xsl:stylesheet>