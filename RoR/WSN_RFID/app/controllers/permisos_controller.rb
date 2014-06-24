class PermisosController < ApplicationController
  before_action :set_permiso, only: [:show, :edit, :update, :destroy]
  before_filter :authorize_permiso
  # GET /permisos
  # GET /permisos.json
  def index
    @permisos = Permiso.all
  end

  # GET /permisos/1
  # GET /permisos/1.json
  def show
  end

  # GET /permisos/new
  def new
    @permiso = Permiso.new
    @label = "Crear"
  end

  # GET /permisos/1/edit
  def edit
    @label = "Actualizar"
  end

  # POST /permisos
  # POST /permisos.json
  def create
    @permiso = Permiso.new(permiso_params)

    respond_to do |format|
      if @permiso.save
        format.html { redirect_to permisos_path, notice: 'Permiso fue creado con éxito.' }
        format.json { render :show, status: :created, location: @permiso }
      else
        format.html { render :new }
        format.json { render json: @permiso.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /permisos/1
  # PATCH/PUT /permisos/1.json
  def update
    respond_to do |format|
      if @permiso.update(permiso_params)
        format.html { redirect_to permisos_path, notice: 'Permiso fue actualizado.' }
        format.json { render :show, status: :ok, location: @permiso }
      else
        format.html { render :edit }
        format.json { render json: @permiso.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /permisos/1
  # DELETE /permisos/1.json
  def destroy
    @permiso.destroy
    respond_to do |format|
      format.html { redirect_to permisos_url, notice: 'Permiso fue eliminado.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_permiso
      @permiso = Permiso.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def permiso_params
      params.require(:permiso).permit(:titulo, :acceso_articulo, :acceso_alerta, :acceso_lectura, :acceso_lector ,:acceso_paquete, :acceso_usuario, :acceso_permiso, :acceso_alerta, :acceso_vehiculo, :acceso_persona, :acceso_atributo )
    end
end
