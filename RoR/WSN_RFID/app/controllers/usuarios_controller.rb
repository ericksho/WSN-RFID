class UsuariosController < ApplicationController
  before_action :set_usuario, only: [:show, :edit, :update, :destroy]
  skip_before_filter :require_login
  before_filter :authorize_usuario
  
  # GET /usuarios
  # GET /usuarios.json
  def index
    @usuarios = Usuario.all
  end

  # GET /usuarios/1
  # GET /usuarios/1.json
  def show
  end

  # GET /usuarios/new
  def new
    @usuario = Usuario.new
     @label = "Crear"
  end

  # GET /usuarios/1/edit
  def edit
    @label = "Actualizar"
  end

  # POST /usuarios
  # POST /usuarios.json
  def create
    @usuario = Usuario.new(usuario_params)
    @permiso = Permiso.find(params[:permiso_select]['id'])
    @usuario.cargo = @permiso.titulo
    respond_to do |format|
      if @usuario.save
        @usuario.permisos << @permiso
        @usuario.save!
        format.html { redirect_to usuarios_path, notice: 'Usuario fue creado con éxito.' }
        format.json { render :show, status: :created, location: @usuario }
      else
        format.html { render :new }
        format.json { render json: @usuario.errors, status: :unprocessable_entity }
      end
    end
  end

  # PATCH/PUT /usuarios/1
  # PATCH/PUT /usuarios/1.json
  def update
    @permiso = Permiso.find(params[:permiso_select]['id'])
    @usuario.cargo = @permiso.titulo
    respond_to do |format|
      if @usuario.update(usuario_params)
        @usuario.permisos.clear
        @usuario.permisos << @permiso
        @usuario.save!
        format.html { redirect_to usuarios_path, notice: 'Usuario fue actualizado.' }
        format.json { render :show, status: :ok, location: @usuario }
      else
        format.html { render :edit }
        format.json { render json: @usuario.errors, status: :unprocessable_entity }
      end
    end
  end

  # DELETE /usuarios/1
  # DELETE /usuarios/1.json
  def destroy
    @usuario.destroy
    respond_to do |format|
      format.html { redirect_to usuarios_url, notice: 'Usuario fue eliminado.' }
      format.json { head :no_content }
    end
  end

  private
    # Use callbacks to share common setup or constraints between actions.
    def set_usuario
      @usuario = Usuario.find(params[:id])
    end

    # Never trust parameters from the scary internet, only allow the white list through.
    def usuario_params
      params.require(:usuario).permit(:status, :password, :email, :nombre, :apellido, :password_confirmation, :permiso_id, :cargo)
    end
end
