# Manual de Usuario - FarmaSalud

## Índice
1. [Introducción](#introducción)
2. [Inicio de Sesión](#inicio-de-sesión)
3. [Módulo Administrador](#módulo-administrador)
4. [Módulo Gerente](#módulo-gerente)
5. [Módulo Farmacéutico](#módulo-farmacéutico)
6. [Módulo Vendedor](#módulo-vendedor)
7. [Solución de Problemas](#solución-de-problemas)

---

## Introducción

**FarmaSalud** es un sistema de gestión farmacéutica que permite administrar usuarios, inventario de medicamentos, ventas y generar reportes. El sistema cuenta con diferentes roles de usuario:

- **Administrador**: Gestión completa de usuarios y sistema
- **Gerente**: Gestión de reportes y supervisión general
- **Farmacéutico**: Gestión de inventario de medicamentos
- **Vendedor**: Procesamiento de ventas

---

## Inicio de Sesión

### Acceso al Sistema
1. Ejecute la aplicación FarmaSalud
2. Ingrese su **nombre de usuario** y **contraseña**
3. Haga clic en **"Iniciar Sesión"**

### Usuarios Predeterminados
- **Administrador**: 
  - Usuario: `admin` | Contraseña: `123`
- **Gerente**: 
  - Usuario: `mrojas` | Contraseña: `123`
- **Farmacéutico**: 
  - Usuario: `jperez` | Contraseña: `123`
- **Vendedor**: 
  - Usuario: `ctevez` | Contraseña: `123`

---

## Módulo Administrador

### CU-ADM001: Gestión de Usuarios

#### Agregar Usuario
1. Desde el menú principal, seleccione **"Gestión de Usuarios"** → **"Agregar Usuario"**
2. Complete los campos obligatorios:
   - **Nombre** y **Apellido**
   - **Nombre de Usuario** (único en el sistema)
   - **Contraseña**
   - **CUIL** (único)
   - **Email** (único)
   - **Teléfono**
   - **Rol** (seleccione del desplegable)
   - **Matrícula** (solo para farmacéuticos)
3. Haga clic en **"Guardar"**

#### Editar Usuario
1. Seleccione **"Gestión de Usuarios"** → **"Listar Usuarios"**
2. Seleccione el usuario a editar de la lista
3. Haga clic en **"Editar"**
4. Modifique los campos necesarios
5. Haga clic en **"Guardar Cambios"**

#### Eliminar Usuario
1. Seleccione **"Gestión de Usuarios"** → **"Listar Usuarios"**
2. Seleccione el usuario a eliminar
3. Haga clic en **"Eliminar"**
4. Confirme la eliminación en el diálogo

#### Cambiar Rol de Usuario
1. Seleccione **"Gestión de Usuarios"** → **"Cambiar Rol"**
2. Seleccione el usuario
3. Elija el nuevo rol
4. Para farmacéuticos, ingrese la matrícula
5. Haga clic en **"Cambiar Rol"**

### CU-ADM002: Gestión del Sistema
- **Configuración de Base de Datos**: Acceso para modificar parámetros de conexión
- **Respaldos**: Generar copias de seguridad del sistema
- **Logs del Sistema**: Revisar actividad y errores

---

## Módulo Gerente

### CU-GER001: Generar Reportes

#### Reporte de Ventas por Período
1. Seleccione **"Reportes"** → **"Reporte de Ventas"**
2. Configure los parámetros:
   - **Fecha Inicio**: Seleccione desde el calendario
   - **Fecha Fin**: Seleccione hasta el calendario
3. Haga clic en **"Generar Reporte"**
4. El sistema mostrará:
   - Lista de facturas en el período
   - Número de factura
   - Fecha de emisión
   - Total de venta
   - Método de pago
   - Vendedor responsable

#### Reporte de Inventario
1. Seleccione **"Reportes"** → **"Reporte de Inventario"**
2. El sistema mostrará:
   - Medicamentos con stock bajo
   - Medicamentos próximos a vencer
   - Resumen por proveedor

#### Reporte de Usuarios Activos
1. Seleccione **"Reportes"** → **"Usuarios del Sistema"**
2. Visualice la lista completa de usuarios registrados
3. Información mostrada:
   - Datos personales
   - Rol asignado
   - Estado (activo/inactivo)

### CU-GER002: Supervisión de Operaciones
- **Monitoreo de Ventas**: Seguimiento en tiempo real
- **Control de Stock**: Alertas de inventario bajo
- **Análisis de Tendencias**: Reportes estadísticos

---

## Módulo Farmacéutico

### CU-FAR001: Buscar Fármaco
1. Desde el menú principal, seleccione **"Gestión de Medicamentos"** → **"Buscar Fármaco"**
2. Ingrese el **código de inventario** del medicamento
3. Haga clic en **"Buscar"**
4. El sistema mostrará:
   - **Código de Inventario**
   - **Nombre Comercial**
   - **Precio por Unidad**
   - **Stock Disponible**
   - **Fecha de Vencimiento**
   - **Proveedor**
   - **Requiere Receta** (Sí/No)

### CU-FAR002: Eliminar Fármaco
1. Realice una búsqueda del fármaco (CU-FAR001)
2. Una vez encontrado, haga clic en **"Eliminar"**
3. El sistema validará:
   - ✅ **Fármaco existe**: Procede con la eliminación
   - ❌ **Tiene ventas asociadas**: No se puede eliminar
   - ❌ **Tiene solicitudes pendientes**: No se puede eliminar
4. Confirme la eliminación en el diálogo
5. El sistema mostrará mensaje de confirmación

#### Códigos de Fármacos Disponibles:
- `PCT-500-A` - Paracetamol 500mg
- `IBU-400-B` - Ibuprofeno 400mg
- `AMX-500-D` - Amoxicilina 500mg
- `LOR-010-G` - Loratadina 10mg
- `OMP-020-E` - Omeprazol 20mg

### CU-FAR003: Editar Fármaco
1. Busque el fármaco a editar
2. Haga clic en **"Editar"**
3. Modifique los campos permitidos:
   - Nombre comercial
   - Precio por unidad
   - Stock
   - Fecha de vencimiento
4. Haga clic en **"Guardar Cambios"**

### CU-FAR004: Gestión de Inventario
- **Control de Stock**: Monitoreo de cantidades disponibles
- **Alertas de Vencimiento**: Notificaciones de medicamentos próximos a vencer
- **Actualización de Precios**: Modificación de precios por unidad

---

## Módulo Vendedor

### CU-VEN001: Realizar Venta

#### Proceso de Venta
1. Desde el menú principal, seleccione **"Procesar Venta"**
2. **Búsqueda de Medicamento**:
   - Ingrese el código del medicamento
   - Haga clic en **"Buscar"**
   - Verifique disponibilidad de stock
3. **Agregar al Carrito**:
   - Seleccione la cantidad deseada
   - Verifique que no exceda el stock disponible
   - Haga clic en **"Agregar"**
4. **Revisión del Carrito**:
   - Verifique los items agregados
   - Calcule el subtotal automáticamente
5. **Finalizar Venta**:
   - Seleccione **método de pago**:
     - Efectivo
     - Tarjeta de Débito
     - Tarjeta de Crédito
   - Haga clic en **"Procesar Venta"**
6. **Confirmación**:
   - El sistema genera número de factura único
   - Actualiza automáticamente el stock
   - Muestra comprobante de venta

#### Validaciones del Sistema
- ✅ **Stock Suficiente**: Verifica disponibilidad antes de la venta
- ✅ **Medicamentos con Receta**: Solicita validación adicional
- ✅ **Actualización Automática**: Reduce stock después de la venta
- ✅ **Facturación**: Genera comprobante con número único

### CU-VEN002: Consultar Ventas
1. Seleccione **"Consultas"** → **"Mis Ventas"**
2. Visualice el historial de ventas realizadas
3. Filtre por fecha si es necesario

---

## Casos de Uso Detallados

### Generar Reporte (CU-REP001)
**Actor**: Gerente
**Descripción**: Generación de reportes de ventas por período específico

**Flujo Principal**:
1. Gerente accede al módulo de reportes
2. Selecciona "Reporte de Ventas por Fechas"
3. Ingresa fecha de inicio y fecha de fin
4. Sistema valida el rango de fechas
5. Sistema consulta base de datos
6. Sistema genera reporte con:
   - Número de factura
   - Fecha de emisión
   - Total de venta
   - Método de pago utilizado
   - Vendedor responsable
   - CUIL del vendedor
7. Sistema muestra reporte en pantalla

**Flujos Alternativos**:
- **A1**: Si no hay ventas en el período, mostrar mensaje "No se encontraron ventas"
- **A2**: Si las fechas son inválidas, mostrar error de validación

### Buscar Fármaco (CU-FAR001)
**Actor**: Farmacéutico
**Descripción**: Búsqueda de medicamento por código de inventario

**Flujo Principal**:
1. Farmacéutico accede a "Buscar Fármaco"
2. Ingresa código de inventario
3. Sistema busca en base de datos
4. Sistema muestra información completa del medicamento
5. Farmacéutico puede proceder a editar o eliminar

**Flujos Alternativos**:
- **A1**: Si el código no existe, mostrar "Fármaco no encontrado"
- **A2**: Si hay error de conexión, mostrar mensaje de error

### Eliminar Fármaco (CU-FAR002)
**Actor**: Farmacéutico
**Descripción**: Eliminación de medicamento del sistema

**Precondiciones**:
- Usuario autenticado como Farmacéutico
- Fármaco debe existir en el sistema

**Flujo Principal**:
1. Farmacéutico busca el fármaco a eliminar
2. Sistema muestra datos del fármaco
3. Farmacéutico hace clic en "Eliminar"
4. Sistema valida que no tenga ventas asociadas
5. Sistema valida que no tenga solicitudes pendientes
6. Sistema solicita confirmación
7. Farmacéutico confirma eliminación
8. Sistema elimina fármaco de la base de datos
9. Sistema muestra mensaje de éxito

**Flujos Alternativos**:
- **A1**: Si tiene ventas asociadas, mostrar "No se puede eliminar - tiene ventas"
- **A2**: Si tiene solicitudes pendientes, mostrar "No se puede eliminar - tiene solicitudes"
- **A3**: Si el usuario cancela, regresar a la pantalla anterior

### Realizar Venta (CU-VEN001)
**Actor**: Vendedor
**Descripción**: Procesamiento completo de una venta de medicamentos

**Flujo Principal**:
1. Vendedor accede al módulo de ventas
2. Busca medicamento por código
3. Verifica stock disponible
4. Agrega cantidad al carrito
5. Repite pasos 2-4 para múltiples medicamentos
6. Selecciona método de pago
7. Confirma la venta
8. Sistema genera factura
9. Sistema actualiza stock
10. Sistema muestra comprobante

**Reglas de Negocio**:
- No se puede vender más cantidad que el stock disponible
- Los medicamentos con receta requieren validación adicional
- Cada venta genera un número de factura único
- El stock se actualiza automáticamente después de la venta

---

## Solución de Problemas

### Problemas Comunes

#### Error de Conexión a Base de Datos
**Síntoma**: Mensaje "Error de conexión"
**Solución**: 
1. Verificar que SQL Server esté ejecutándose
2. Confirmar cadena de conexión en app.config
3. Verificar permisos de usuario de base de datos

#### Usuario No Puede Iniciar Sesión
**Síntoma**: "Usuario o contraseña incorrectos"
**Solución**:
1. Verificar credenciales
2. Contactar administrador para resetear contraseña
3. Verificar que el usuario esté activo

#### Error al Eliminar Fármaco
**Síntoma**: "No se puede eliminar el fármaco"
**Causa**: El medicamento tiene ventas o solicitudes asociadas
**Solución**: Solo se pueden eliminar medicamentos sin historial de ventas

#### Stock Insuficiente en Venta
**Síntoma**: "Stock insuficiente"
**Solución**: 
1. Verificar stock actual del medicamento
2. Contactar farmacéutico para reposición
3. Reducir cantidad en la venta

### Contacto de Soporte
- **Email**: soporte@farmasalud.com
- **Teléfono**: (011) 4567-8900
- **Horario**: Lunes a Viernes, 8:00 - 18:00

---

## Notas Importantes

### Seguridad
- **Nunca comparta sus credenciales** de acceso
- **Cierre sesión** al terminar de usar el sistema
- **Reporte** cualquier actividad sospechosa al administrador

### Respaldos
- El sistema realiza respaldos automáticos diarios
- Los datos están protegidos y encriptados
- En caso de pérdida de datos, contacte al administrador

### Actualizaciones
- Las actualizaciones se instalan automáticamente
- El sistema notificará sobre nuevas funcionalidades
- Consulte este manual para nuevas características

---

**Versión del Manual**: 1.0  
**Fecha de Actualización**: Julio 2025  
**Sistema**: FarmaSalud v1.0  

*Este manual está sujeto a cambios sin previo aviso. Para la versión más actualizada, consulte con el administrador del sistema.*
